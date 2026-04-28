using System;
using System.Globalization;
using System.Net.Http;
using System.Xml.Linq;
using System.Text;
using ConverterApp;



namespace CurrencyApp
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            choseDateTime.MaxDate = DateTime.Today;

        }

        private static readonly HttpClient client = new HttpClient();
        private Dictionary<string, double> CurrencyAndUnits = new Dictionary<string, double> { }; // Словарь для заполнения данными
        private XDocument doc;
        private async void connectToServer_Click(object sender, EventArgs e)
        {
            try
            {
                CurrencyAndUnits.Clear();
                cmbFromCurrency.Items.Clear();
                cmbToCurrency.Items.Clear();
                DataGrid.Rows.Clear();

                string url = $"https://www.cbr.ru/scripts/XML_daily.asp?date_req={choseDateTime.Value:dd/MM/yyyy}";
                var xml = await client.GetStringAsync(url);
                doc = XDocument.Parse(xml);

                CurrencyAndUnits["RUB"] = 1.0;
                cmbFromCurrency.Items.Add("RUB");
                cmbToCurrency.Items.Add("RUB");

                var culture = new CultureInfo("ru-RU");

                foreach (var item in doc.Descendants("Valute"))
                {
                    var code = item.Element("CharCode")?.Value;
                    if (string.IsNullOrWhiteSpace(code))
                        continue;

                    var name = item.Element("Name")?.Value;
                    var numCode = item.Element("NumCode")?.Value;
                    var nominalStr = item.Element("Nominal")?.Value;
                    var valueStr = item.Element("Value")?.Value;

                    if (!double.TryParse(valueStr, NumberStyles.Any, culture, out double value))
                        continue;

                    if (!double.TryParse(nominalStr, NumberStyles.Any, culture, out double nominal))
                        continue;

                    double rate = value / nominal;

                    CurrencyAndUnits[code] = rate;

                    DataGrid.Rows.Add(
                        choseDateTime.Value.ToString("dd/MM/yyyy"),
                        name,
                        numCode,
                        nominalStr,
                        code,
                        valueStr
                    );

                    cmbFromCurrency.Items.Add(code);
                    cmbToCurrency.Items.Add(code);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Ошибка подключения к серверу.");
            }
        }

        private void btnConvertCurrency_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(inpSum.Text, out double total))
            {
                MessageBox.Show("Введите корректное числовое значение.");
                return;
            }

            if (total < 0)
            {
                MessageBox.Show("Сумма не может быть отрицательной.");
                return;
            }

            try
            {
                string fromCurrency = cmbFromCurrency.SelectedItem?.ToString();
                string toCurrency = cmbToCurrency.SelectedItem?.ToString();

                if (fromCurrency == null || toCurrency == null)
                {
                    MessageBox.Show("Селектор с выбором не может быть пустым. Выберите курсы.");
                    return;
                }

                double fromRate = CurrencyAndUnits[fromCurrency];
                double toRate = CurrencyAndUnits[toCurrency];

                double result = total * (fromRate / toRate); // Основная формула

                totalSum.Text = result.ToString("F2");
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Данные для выбранной валюты не найдены. Попробуйте загрузить курсы.");
            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            if (doc == null)
            {
                MessageBox.Show("Чтобы распарсить XML нужно загрузить курсы. Повторите попытку.");
            }

            else
            {
                string folderPath = Path.Combine(Application.StartupPath, "XML-response");
                string filePath = Path.Combine(folderPath, "rates.xml");
                doc.Save(filePath);

                MessageBox.Show($"Файл сохранен по пути {folderPath}");
            }

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutFrom = new AboutForm();
            aboutFrom.Show();
        }
    }
}
