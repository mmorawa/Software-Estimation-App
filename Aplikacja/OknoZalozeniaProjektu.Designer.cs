﻿namespace Aplikacja
{
    partial class OknoZalozeniaProjektu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAnuluj = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.GroupBoxSzczDaneProjektu = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxJezykProgram = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelDataRozp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericStawkaGodz = new System.Windows.Forms.NumericUpDown();
            this.NumericOsoboMGodz = new System.Windows.Forms.NumericUpDown();
            this.NumericDzRobGodz = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GroupBoxOgraniczenia = new System.Windows.Forms.GroupBox();
            this.CheckBoxAktywacja = new System.Windows.Forms.CheckBox();
            this.TableLayoutOgraniczenia = new System.Windows.Forms.TableLayoutPanel();
            this.NumericMaxKoszt = new System.Windows.Forms.NumericUpDown();
            this.NumericMaxPrac = new System.Windows.Forms.NumericUpDown();
            this.NumericMaxHarm = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.GroupBoxSzczDaneProjektu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStawkaGodz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericOsoboMGodz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDzRobGodz)).BeginInit();
            this.GroupBoxOgraniczenia.SuspendLayout();
            this.TableLayoutOgraniczenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxKoszt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxPrac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxHarm)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAnuluj
            // 
            this.ButtonAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAnuluj.Location = new System.Drawing.Point(311, 584);
            this.ButtonAnuluj.Name = "ButtonAnuluj";
            this.ButtonAnuluj.Size = new System.Drawing.Size(104, 27);
            this.ButtonAnuluj.TabIndex = 13;
            this.ButtonAnuluj.Text = "Anuluj";
            this.ButtonAnuluj.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOk.Location = new System.Drawing.Point(151, 584);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(104, 27);
            this.ButtonOk.TabIndex = 12;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSzczDaneProjektu
            // 
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.tableLayoutPanel2);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.GroupBoxOgraniczenia);
            this.GroupBoxSzczDaneProjektu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxSzczDaneProjektu.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxSzczDaneProjektu.Name = "GroupBoxSzczDaneProjektu";
            this.GroupBoxSzczDaneProjektu.Size = new System.Drawing.Size(569, 556);
            this.GroupBoxSzczDaneProjektu.TabIndex = 15;
            this.GroupBoxSzczDaneProjektu.TabStop = false;
            this.GroupBoxSzczDaneProjektu.Text = "Założenia projektu";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.Controls.Add(this.ComboBoxJezykProgram, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelDataRozp, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.NumericStawkaGodz, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.NumericOsoboMGodz, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.NumericDzRobGodz, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(476, 199);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // ComboBoxJezykProgram
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.ComboBoxJezykProgram, 2);
            this.ComboBoxJezykProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxJezykProgram.FormattingEnabled = true;
            this.ComboBoxJezykProgram.Items.AddRange(new object[] {
            "ABAP (SAP) ",
            "ASP",
            "Assembler",
            "Brio",
            "C",
            "C++",
            "C#",
            "COBOL",
            "Cognos Impromptu Scripts",
            "Cross System Products (CSP)",
            "Cool:Gen/IEF",
            "Datastage",
            "Excel",
            "Focus",
            "FoxPro",
            "HTML",
            "J2EE",
            "Java",
            "JavaScript",
            "JCL",
            "LINC II",
            "Lotus Notes",
            "Natural",
            ".NET",
            "Oracle",
            "PACBASE",
            "Perl",
            "PL/I",
            "PL/SQL",
            "Powerbuilder",
            "REXX",
            "Sabretalk",
            "SAS",
            "Siebel",
            "SLOGAN",
            "SQL",
            "VB.NET",
            "Visual Basic"});
            this.ComboBoxJezykProgram.Location = new System.Drawing.Point(188, 13);
            this.ComboBoxJezykProgram.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.ComboBoxJezykProgram.Name = "ComboBoxJezykProgram";
            this.ComboBoxJezykProgram.Size = new System.Drawing.Size(285, 24);
            this.ComboBoxJezykProgram.TabIndex = 32;
            this.ComboBoxJezykProgram.SelectedIndexChanged += new System.EventHandler(this.ComboBoxJezykProgram_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 49);
            this.label8.TabIndex = 30;
            this.label8.Text = "Główny język programowania użyty w projekcie";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelDataRozp
            // 
            this.LabelDataRozp.AutoSize = true;
            this.LabelDataRozp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDataRozp.Location = new System.Drawing.Point(3, 49);
            this.LabelDataRozp.Name = "LabelDataRozp";
            this.LabelDataRozp.Size = new System.Drawing.Size(179, 49);
            this.LabelDataRozp.TabIndex = 4;
            this.LabelDataRozp.Text = "Stawka godzinowa:";
            this.LabelDataRozp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "1 osobomiesiąc stanowi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumericStawkaGodz
            // 
            this.NumericStawkaGodz.DecimalPlaces = 2;
            this.NumericStawkaGodz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericStawkaGodz.Location = new System.Drawing.Point(188, 62);
            this.NumericStawkaGodz.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.NumericStawkaGodz.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.NumericStawkaGodz.Name = "NumericStawkaGodz";
            this.NumericStawkaGodz.Size = new System.Drawing.Size(170, 22);
            this.NumericStawkaGodz.TabIndex = 16;
            this.NumericStawkaGodz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericStawkaGodz.ThousandsSeparator = true;
            this.NumericStawkaGodz.ValueChanged += new System.EventHandler(this.NumericStawkaGodz_ValueChanged);
            // 
            // NumericOsoboMGodz
            // 
            this.NumericOsoboMGodz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericOsoboMGodz.Location = new System.Drawing.Point(188, 111);
            this.NumericOsoboMGodz.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.NumericOsoboMGodz.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.NumericOsoboMGodz.Name = "NumericOsoboMGodz";
            this.NumericOsoboMGodz.Size = new System.Drawing.Size(170, 22);
            this.NumericOsoboMGodz.TabIndex = 24;
            this.NumericOsoboMGodz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericOsoboMGodz.ThousandsSeparator = true;
            this.NumericOsoboMGodz.ValueChanged += new System.EventHandler(this.NumericOsoboMGodz_ValueChanged);
            // 
            // NumericDzRobGodz
            // 
            this.NumericDzRobGodz.Location = new System.Drawing.Point(188, 160);
            this.NumericDzRobGodz.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.NumericDzRobGodz.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.NumericDzRobGodz.Name = "NumericDzRobGodz";
            this.NumericDzRobGodz.Size = new System.Drawing.Size(170, 22);
            this.NumericDzRobGodz.TabIndex = 26;
            this.NumericDzRobGodz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericDzRobGodz.ThousandsSeparator = true;
            this.NumericDzRobGodz.ValueChanged += new System.EventHandler(this.NumericDzRobGodz_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(364, 150);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 49);
            this.label13.TabIndex = 27;
            this.label13.Text = "godzin";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dzień roboczy wynosi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(364, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 49);
            this.label7.TabIndex = 19;
            this.label7.Text = "zł";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(364, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 46);
            this.label12.TabIndex = 25;
            this.label12.Text = "osobogodzin";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupBoxOgraniczenia
            // 
            this.GroupBoxOgraniczenia.Controls.Add(this.CheckBoxAktywacja);
            this.GroupBoxOgraniczenia.Controls.Add(this.TableLayoutOgraniczenia);
            this.GroupBoxOgraniczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxOgraniczenia.Location = new System.Drawing.Point(6, 304);
            this.GroupBoxOgraniczenia.Name = "GroupBoxOgraniczenia";
            this.GroupBoxOgraniczenia.Size = new System.Drawing.Size(540, 221);
            this.GroupBoxOgraniczenia.TabIndex = 16;
            this.GroupBoxOgraniczenia.TabStop = false;
            this.GroupBoxOgraniczenia.Text = "Ograniczenia";
            // 
            // CheckBoxAktywacja
            // 
            this.CheckBoxAktywacja.AutoSize = true;
            this.CheckBoxAktywacja.Location = new System.Drawing.Point(12, 32);
            this.CheckBoxAktywacja.Name = "CheckBoxAktywacja";
            this.CheckBoxAktywacja.Size = new System.Drawing.Size(97, 20);
            this.CheckBoxAktywacja.TabIndex = 30;
            this.CheckBoxAktywacja.Text = "Aktywacja";
            this.CheckBoxAktywacja.UseVisualStyleBackColor = true;
            this.CheckBoxAktywacja.CheckedChanged += new System.EventHandler(this.CheckBoxAktywacja_CheckedChanged);
            // 
            // TableLayoutOgraniczenia
            // 
            this.TableLayoutOgraniczenia.ColumnCount = 3;
            this.TableLayoutOgraniczenia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.TableLayoutOgraniczenia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.TableLayoutOgraniczenia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.TableLayoutOgraniczenia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutOgraniczenia.Controls.Add(this.NumericMaxKoszt, 1, 2);
            this.TableLayoutOgraniczenia.Controls.Add(this.label6, 0, 0);
            this.TableLayoutOgraniczenia.Controls.Add(this.label16, 2, 2);
            this.TableLayoutOgraniczenia.Controls.Add(this.NumericMaxPrac, 1, 0);
            this.TableLayoutOgraniczenia.Controls.Add(this.label17, 2, 0);
            this.TableLayoutOgraniczenia.Controls.Add(this.label5, 0, 2);
            this.TableLayoutOgraniczenia.Controls.Add(this.label10, 0, 1);
            this.TableLayoutOgraniczenia.Controls.Add(this.NumericMaxHarm, 1, 1);
            this.TableLayoutOgraniczenia.Controls.Add(this.label14, 2, 1);
            this.TableLayoutOgraniczenia.Enabled = false;
            this.TableLayoutOgraniczenia.Location = new System.Drawing.Point(6, 69);
            this.TableLayoutOgraniczenia.Name = "TableLayoutOgraniczenia";
            this.TableLayoutOgraniczenia.RowCount = 3;
            this.TableLayoutOgraniczenia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutOgraniczenia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutOgraniczenia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutOgraniczenia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutOgraniczenia.Size = new System.Drawing.Size(540, 131);
            this.TableLayoutOgraniczenia.TabIndex = 29;
            // 
            // NumericMaxKoszt
            // 
            this.NumericMaxKoszt.DecimalPlaces = 2;
            this.NumericMaxKoszt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericMaxKoszt.Location = new System.Drawing.Point(226, 102);
            this.NumericMaxKoszt.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.NumericMaxKoszt.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.NumericMaxKoszt.Name = "NumericMaxKoszt";
            this.NumericMaxKoszt.Size = new System.Drawing.Size(154, 22);
            this.NumericMaxKoszt.TabIndex = 16;
            this.NumericMaxKoszt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericMaxKoszt.ThousandsSeparator = true;
            this.NumericMaxKoszt.ValueChanged += new System.EventHandler(this.NumericMaxKoszt_ValueChanged);
            // 
            // NumericMaxPrac
            // 
            this.NumericMaxPrac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericMaxPrac.Location = new System.Drawing.Point(226, 13);
            this.NumericMaxPrac.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.NumericMaxPrac.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.NumericMaxPrac.Name = "NumericMaxPrac";
            this.NumericMaxPrac.Size = new System.Drawing.Size(154, 22);
            this.NumericMaxPrac.TabIndex = 24;
            this.NumericMaxPrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericMaxPrac.ThousandsSeparator = true;
            this.NumericMaxPrac.ValueChanged += new System.EventHandler(this.NumericMaxPrac_ValueChanged);
            // 
            // NumericMaxHarm
            // 
            this.NumericMaxHarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericMaxHarm.Location = new System.Drawing.Point(226, 61);
            this.NumericMaxHarm.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.NumericMaxHarm.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.NumericMaxHarm.Name = "NumericMaxHarm";
            this.NumericMaxHarm.Size = new System.Drawing.Size(154, 22);
            this.NumericMaxHarm.TabIndex = 26;
            this.NumericMaxHarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericMaxHarm.ThousandsSeparator = true;
            this.NumericMaxHarm.ValueChanged += new System.EventHandler(this.NumericMaxHarm_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(386, 51);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 38);
            this.label14.TabIndex = 27;
            this.label14.Text = "miesięcy";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 48);
            this.label6.TabIndex = 17;
            this.label6.Text = "Maksymalna pracochłonność:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 42);
            this.label5.TabIndex = 15;
            this.label5.Text = "Maksymalny koszt:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(386, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 42);
            this.label16.TabIndex = 19;
            this.label16.Text = "zł";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(3, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 41);
            this.label10.TabIndex = 21;
            this.label10.Text = "Maksymalny harmonogram:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(386, 3);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 45);
            this.label17.TabIndex = 25;
            this.label17.Text = "osobomiesięcy";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OknoZalozeniaProjektu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 629);
            this.Controls.Add(this.GroupBoxSzczDaneProjektu);
            this.Controls.Add(this.ButtonAnuluj);
            this.Controls.Add(this.ButtonOk);
            this.Name = "OknoZalozeniaProjektu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Założenia projektu";
            this.GroupBoxSzczDaneProjektu.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStawkaGodz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericOsoboMGodz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDzRobGodz)).EndInit();
            this.GroupBoxOgraniczenia.ResumeLayout(false);
            this.GroupBoxOgraniczenia.PerformLayout();
            this.TableLayoutOgraniczenia.ResumeLayout(false);
            this.TableLayoutOgraniczenia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxKoszt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxPrac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxHarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAnuluj;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.GroupBox GroupBoxSzczDaneProjektu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelDataRozp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumericStawkaGodz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown NumericDzRobGodz;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown NumericOsoboMGodz;
        private System.Windows.Forms.GroupBox GroupBoxOgraniczenia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel TableLayoutOgraniczenia;
        private System.Windows.Forms.NumericUpDown NumericMaxKoszt;
        private System.Windows.Forms.NumericUpDown NumericMaxPrac;
        private System.Windows.Forms.NumericUpDown NumericMaxHarm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox CheckBoxAktywacja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBoxJezykProgram;
    }
}