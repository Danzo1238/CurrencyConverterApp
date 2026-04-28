namespace CurrencyApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lDate = new Label();
            choseDateTime = new DateTimePicker();
            lTotalSum = new Label();
            lSum = new Label();
            lToC = new Label();
            lFromC = new Label();
            totalSum = new TextBox();
            inpSum = new TextBox();
            DataGrid = new DataGridView();
            FromDate = new DataGridViewTextBoxColumn();
            NameValue = new DataGridViewTextBoxColumn();
            VnCode = new DataGridViewTextBoxColumn();
            Nominal = new DataGridViewTextBoxColumn();
            Currency = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            cmbFromCurrency = new ComboBox();
            connectToServer = new Button();
            btnConvertCurrency = new Button();
            cmbToCurrency = new ComboBox();
            menuForm = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            закрытьToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            btnXML = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            menuForm.SuspendLayout();
            SuspendLayout();
            // 
            // lDate
            // 
            lDate.AutoSize = true;
            lDate.BackColor = Color.Gray;
            lDate.Font = new Font("Segoe UI", 12F);
            lDate.Location = new Point(54, 224);
            lDate.Name = "lDate";
            lDate.Size = new Size(84, 28);
            lDate.TabIndex = 12;
            lDate.Text = "На дату:";
            // 
            // choseDateTime
            // 
            choseDateTime.Location = new Point(144, 226);
            choseDateTime.MaxDate = new DateTime(2026, 4, 28, 0, 0, 0, 0);
            choseDateTime.Name = "choseDateTime";
            choseDateTime.Size = new Size(140, 27);
            choseDateTime.TabIndex = 11;
            choseDateTime.Value = new DateTime(2026, 4, 24, 0, 0, 0, 0);
            // 
            // lTotalSum
            // 
            lTotalSum.AutoSize = true;
            lTotalSum.BackColor = Color.Gray;
            lTotalSum.Font = new Font("Segoe UI", 12F);
            lTotalSum.Location = new Point(308, 118);
            lTotalSum.Name = "lTotalSum";
            lTotalSum.Size = new Size(59, 28);
            lTotalSum.TabIndex = 10;
            lTotalSum.Text = "Итог:";
            // 
            // lSum
            // 
            lSum.AutoSize = true;
            lSum.BackColor = Color.Gray;
            lSum.Font = new Font("Segoe UI", 12F);
            lSum.Location = new Point(51, 119);
            lSum.Name = "lSum";
            lSum.Size = new Size(76, 28);
            lSum.TabIndex = 9;
            lSum.Text = "Сумма:";
            // 
            // lToC
            // 
            lToC.AutoSize = true;
            lToC.BackColor = Color.Gray;
            lToC.Font = new Font("Segoe UI", 12F);
            lToC.Location = new Point(340, 58);
            lToC.Name = "lToC";
            lToC.Size = new Size(27, 28);
            lToC.TabIndex = 8;
            lToC.Text = "В:";
            // 
            // lFromC
            // 
            lFromC.AutoSize = true;
            lFromC.BackColor = Color.Gray;
            lFromC.Font = new Font("Segoe UI", 12F);
            lFromC.Location = new Point(87, 58);
            lFromC.Name = "lFromC";
            lFromC.Size = new Size(40, 28);
            lFromC.TabIndex = 7;
            lFromC.Text = "Из:";
            // 
            // totalSum
            // 
            totalSum.Location = new Point(373, 119);
            totalSum.Name = "totalSum";
            totalSum.ReadOnly = true;
            totalSum.Size = new Size(125, 27);
            totalSum.TabIndex = 5;
            // 
            // inpSum
            // 
            inpSum.Location = new Point(133, 119);
            inpSum.Name = "inpSum";
            inpSum.Size = new Size(125, 27);
            inpSum.TabIndex = 4;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { FromDate, NameValue, VnCode, Nominal, Currency, Value });
            DataGrid.Location = new Point(12, 259);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersVisible = false;
            DataGrid.RowHeadersWidth = 51;
            DataGrid.Size = new Size(577, 176);
            DataGrid.TabIndex = 1;
            // 
            // FromDate
            // 
            FromDate.HeaderText = "Дата";
            FromDate.MinimumWidth = 6;
            FromDate.Name = "FromDate";
            FromDate.Width = 125;
            // 
            // NameValue
            // 
            NameValue.HeaderText = "Название валюты";
            NameValue.MinimumWidth = 6;
            NameValue.Name = "NameValue";
            NameValue.Width = 125;
            // 
            // VnCode
            // 
            VnCode.HeaderText = "Код валюты";
            VnCode.MinimumWidth = 6;
            VnCode.Name = "VnCode";
            VnCode.Width = 125;
            // 
            // Nominal
            // 
            Nominal.HeaderText = "Номинал";
            Nominal.MinimumWidth = 6;
            Nominal.Name = "Nominal";
            Nominal.Width = 125;
            // 
            // Currency
            // 
            Currency.HeaderText = "Символьный код";
            Currency.MinimumWidth = 6;
            Currency.Name = "Currency";
            Currency.Width = 125;
            // 
            // Value
            // 
            Value.HeaderText = "Значение";
            Value.MinimumWidth = 6;
            Value.Name = "Value";
            Value.Width = 125;
            // 
            // cmbFromCurrency
            // 
            cmbFromCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFromCurrency.FormattingEnabled = true;
            cmbFromCurrency.Location = new Point(133, 58);
            cmbFromCurrency.Name = "cmbFromCurrency";
            cmbFromCurrency.Size = new Size(125, 28);
            cmbFromCurrency.TabIndex = 2;
            // 
            // connectToServer
            // 
            connectToServer.Location = new Point(54, 167);
            connectToServer.Name = "connectToServer";
            connectToServer.Size = new Size(140, 38);
            connectToServer.TabIndex = 0;
            connectToServer.Text = "Загрузить курсы";
            connectToServer.UseVisualStyleBackColor = true;
            connectToServer.Click += connectToServer_Click;
            // 
            // btnConvertCurrency
            // 
            btnConvertCurrency.Location = new Point(340, 214);
            btnConvertCurrency.Name = "btnConvertCurrency";
            btnConvertCurrency.Size = new Size(151, 39);
            btnConvertCurrency.TabIndex = 6;
            btnConvertCurrency.Text = "Конвертировать";
            btnConvertCurrency.UseVisualStyleBackColor = true;
            btnConvertCurrency.Click += btnConvertCurrency_Click;
            // 
            // cmbToCurrency
            // 
            cmbToCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToCurrency.FormattingEnabled = true;
            cmbToCurrency.Location = new Point(373, 58);
            cmbToCurrency.Name = "cmbToCurrency";
            cmbToCurrency.Size = new Size(125, 28);
            cmbToCurrency.TabIndex = 3;
            // 
            // menuForm
            // 
            menuForm.ImageScalingSize = new Size(20, 20);
            menuForm.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuForm.Location = new Point(0, 0);
            menuForm.Name = "menuForm";
            menuForm.Size = new Size(601, 28);
            menuForm.TabIndex = 13;
            menuForm.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { закрытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            закрытьToolStripMenuItem.Size = new Size(224, 26);
            закрытьToolStripMenuItem.Text = "Закрыть";
            закрытьToolStripMenuItem.Click += закрытьToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(224, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // btnXML
            // 
            btnXML.Location = new Point(373, 179);
            btnXML.Name = "btnXML";
            btnXML.Size = new Size(94, 29);
            btnXML.TabIndex = 14;
            btnXML.Text = "как XML";
            btnXML.UseVisualStyleBackColor = true;
            btnXML.Click += btnXML_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(601, 432);
            Controls.Add(btnXML);
            Controls.Add(btnConvertCurrency);
            Controls.Add(totalSum);
            Controls.Add(lTotalSum);
            Controls.Add(lDate);
            Controls.Add(cmbToCurrency);
            Controls.Add(lToC);
            Controls.Add(lSum);
            Controls.Add(lFromC);
            Controls.Add(DataGrid);
            Controls.Add(inpSum);
            Controls.Add(choseDateTime);
            Controls.Add(cmbFromCurrency);
            Controls.Add(connectToServer);
            Controls.Add(menuForm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuForm;
            Name = "MainForm";
            Text = "Конвертер величин и валют";
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            menuForm.ResumeLayout(false);
            menuForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lDate;
        private DateTimePicker choseDateTime;
        private Label lTotalSum;
        private Label lSum;
        private Label lToC;
        private Label lFromC;
        private TextBox totalSum;
        private TextBox inpSum;
        private DataGridView DataGrid;
        private DataGridViewTextBoxColumn FromDate;
        private DataGridViewTextBoxColumn NameValue;
        private DataGridViewTextBoxColumn VnCode;
        private DataGridViewTextBoxColumn Nominal;
        private DataGridViewTextBoxColumn Currency;
        private DataGridViewTextBoxColumn Value;
        private ComboBox cmbFromCurrency;
        private Button connectToServer;
        private Button btnConvertCurrency;
        private ComboBox cmbToCurrency;
        private MenuStrip menuForm;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private Button btnXML;
        private ToolStripMenuItem закрытьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}
