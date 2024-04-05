namespace Formularz
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            opcja3 = new RadioButton();
            opcja2 = new RadioButton();
            opcja1 = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            PensjaBox = new NumericUpDown();
            StanowiskoBox = new ComboBox();
            DataBox = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            NazwiskoBox = new TextBox();
            label1 = new Label();
            ImieBox = new TextBox();
            ErrorProvider = new ErrorProvider(components);
            dataGridView = new DataGridView();
            Imie = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            DataUrodzenia = new DataGridViewTextBoxColumn();
            Pensja = new DataGridViewTextBoxColumn();
            Stanowisko = new DataGridViewTextBoxColumn();
            RodzajUmowy = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PensjaBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(opcja3);
            groupBox1.Controls.Add(opcja2);
            groupBox1.Controls.Add(opcja1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(PensjaBox);
            groupBox1.Controls.Add(StanowiskoBox);
            groupBox1.Controls.Add(DataBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(NazwiskoBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ImieBox);
            groupBox1.Location = new Point(28, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 656);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(253, 563);
            button3.Name = "button3";
            button3.Size = new Size(176, 34);
            button3.TabIndex = 18;
            button3.Text = "Load";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(41, 563);
            button2.Name = "button2";
            button2.Size = new Size(155, 34);
            button2.TabIndex = 17;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(41, 499);
            button1.Name = "button1";
            button1.Size = new Size(388, 34);
            button1.TabIndex = 16;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // opcja3
            // 
            opcja3.AutoSize = true;
            opcja3.Location = new Point(198, 437);
            opcja3.Name = "opcja3";
            opcja3.Size = new Size(164, 29);
            opcja3.TabIndex = 15;
            opcja3.TabStop = true;
            opcja3.Text = "Umowa zlecenie";
            opcja3.UseVisualStyleBackColor = true;
            // 
            // opcja2
            // 
            opcja2.AutoSize = true;
            opcja2.Location = new Point(198, 392);
            opcja2.Name = "opcja2";
            opcja2.Size = new Size(242, 29);
            opcja2.TabIndex = 14;
            opcja2.TabStop = true;
            opcja2.Text = "Umowa na czas określony";
            opcja2.UseVisualStyleBackColor = true;
            // 
            // opcja1
            // 
            opcja1.AutoSize = true;
            opcja1.Location = new Point(198, 347);
            opcja1.Name = "opcja1";
            opcja1.Size = new Size(266, 29);
            opcja1.TabIndex = 13;
            opcja1.TabStop = true;
            opcja1.Text = "Umowa na czas nieokreśłony";
            opcja1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 347);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 12;
            label6.Text = "Rodzaj umowy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 285);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 11;
            label5.Text = "Stanowisko:";
            // 
            // PensjaBox
            // 
            PensjaBox.Location = new Point(198, 218);
            PensjaBox.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            PensjaBox.Name = "PensjaBox";
            PensjaBox.Size = new Size(180, 31);
            PensjaBox.TabIndex = 10;
            PensjaBox.ThousandsSeparator = true;
            PensjaBox.Validating += PensjaBox_Validating;
            // 
            // StanowiskoBox
            // 
            StanowiskoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StanowiskoBox.FormattingEnabled = true;
            StanowiskoBox.Items.AddRange(new object[] { "Tester", "Projektant", "Inżynier", "Młodszy programista", "Starszy programista" });
            StanowiskoBox.Location = new Point(198, 277);
            StanowiskoBox.Name = "StanowiskoBox";
            StanowiskoBox.Size = new Size(182, 33);
            StanowiskoBox.TabIndex = 9;
            StanowiskoBox.Validating += StanowiskoBox_Validating;
            // 
            // DataBox
            // 
            DataBox.Format = DateTimePickerFormat.Short;
            DataBox.Location = new Point(198, 161);
            DataBox.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            DataBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DataBox.Name = "DataBox";
            DataBox.Size = new Size(231, 31);
            DataBox.TabIndex = 8;
            DataBox.Validating += DataBox_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 220);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 7;
            label4.Text = "Pensja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 161);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 5;
            label3.Text = "Data Urodzenia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 98);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Nazwisko:";
            // 
            // NazwiskoBox
            // 
            NazwiskoBox.Location = new Point(198, 95);
            NazwiskoBox.Name = "NazwiskoBox";
            NazwiskoBox.Size = new Size(231, 31);
            NazwiskoBox.TabIndex = 2;
            NazwiskoBox.Validating += textBox_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 33);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 1;
            label1.Text = "Imie:";
            // 
            // ImieBox
            // 
            ImieBox.Location = new Point(198, 30);
            ImieBox.Name = "ImieBox";
            ImieBox.Size = new Size(231, 31);
            ImieBox.TabIndex = 0;
            ImieBox.Validating += textBox_Validating;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Imie, Nazwisko, DataUrodzenia, Pensja, Stanowisko, RodzajUmowy });
            dataGridView.GridColor = SystemColors.WindowText;
            dataGridView.Location = new Point(529, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1143, 656);
            dataGridView.TabIndex = 1;
            // 
            // Imie
            // 
            Imie.HeaderText = "Imie";
            Imie.MinimumWidth = 8;
            Imie.Name = "Imie";
            Imie.ReadOnly = true;
            Imie.Width = 150;
            // 
            // Nazwisko
            // 
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.MinimumWidth = 8;
            Nazwisko.Name = "Nazwisko";
            Nazwisko.ReadOnly = true;
            Nazwisko.Width = 150;
            // 
            // DataUrodzenia
            // 
            DataUrodzenia.HeaderText = "Data Urodzenia";
            DataUrodzenia.MinimumWidth = 8;
            DataUrodzenia.Name = "DataUrodzenia";
            DataUrodzenia.ReadOnly = true;
            DataUrodzenia.Width = 150;
            // 
            // Pensja
            // 
            Pensja.HeaderText = "Pensja";
            Pensja.MinimumWidth = 8;
            Pensja.Name = "Pensja";
            Pensja.ReadOnly = true;
            Pensja.Width = 150;
            // 
            // Stanowisko
            // 
            Stanowisko.HeaderText = "Stanowisko";
            Stanowisko.MinimumWidth = 8;
            Stanowisko.Name = "Stanowisko";
            Stanowisko.ReadOnly = true;
            Stanowisko.Width = 150;
            // 
            // RodzajUmowy
            // 
            RodzajUmowy.HeaderText = "Rodzaj Umowy";
            RodzajUmowy.MinimumWidth = 8;
            RodzajUmowy.Name = "RodzajUmowy";
            RodzajUmowy.ReadOnly = true;
            RodzajUmowy.Width = 250;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 641);
            Controls.Add(dataGridView);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PensjaBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private NumericUpDown PensjaBox;
        private ComboBox StanowiskoBox;
        private DateTimePicker DataBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox NazwiskoBox;
        private Label label1;
        private TextBox ImieBox;
        private Button button3;
        private Button button2;
        private Button button1;
        private RadioButton opcja3;
        private RadioButton opcja2;
        private RadioButton opcja1;
        private ErrorProvider ErrorProvider;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Imie;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn DataUrodzenia;
        private DataGridViewTextBoxColumn Pensja;
        private DataGridViewTextBoxColumn Stanowisko;
        private DataGridViewTextBoxColumn RodzajUmowy;
    }
}
