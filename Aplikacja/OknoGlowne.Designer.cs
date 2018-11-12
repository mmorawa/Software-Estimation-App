namespace Aplikacja
{
    partial class OknoGlowne
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
            this.PasekMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuNowyProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuOtworzProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuZapiszProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuZapiszJakoProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuWyjscie = new System.Windows.Forms.ToolStripMenuItem();
            this.raportyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalibracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przelicznikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DaneProjektu = new System.Windows.Forms.GroupBox();
            this.LabelDataRozp = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelNazwaProjektu = new System.Windows.Forms.Label();
            this.TextBoxNazwaProjektu = new System.Windows.Forms.TextBox();
            this.PasekMenu.SuspendLayout();
            this.DaneProjektu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasekMenu
            // 
            this.PasekMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.raportyToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.PasekMenu.Location = new System.Drawing.Point(0, 0);
            this.PasekMenu.Name = "PasekMenu";
            this.PasekMenu.Size = new System.Drawing.Size(1321, 24);
            this.PasekMenu.TabIndex = 0;
            this.PasekMenu.Text = "Pasek Menu";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuNowyProj,
            this.ToolStripMenuOtworzProj,
            this.ToolStripMenuZapiszProj,
            this.ToolStripMenuZapiszJakoProj,
            this.ToolStripMenuWyjscie});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // ToolStripMenuNowyProj
            // 
            this.ToolStripMenuNowyProj.Name = "ToolStripMenuNowyProj";
            this.ToolStripMenuNowyProj.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuNowyProj.Text = "&Nowy projekt";
            this.ToolStripMenuNowyProj.Click += new System.EventHandler(this.ToolStripMenuNowyProj_Click);
            // 
            // ToolStripMenuOtworzProj
            // 
            this.ToolStripMenuOtworzProj.Name = "ToolStripMenuOtworzProj";
            this.ToolStripMenuOtworzProj.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuOtworzProj.Text = "&Otwórz projekt";
            this.ToolStripMenuOtworzProj.Click += new System.EventHandler(this.ToolStripMenuOtworzProj_Click);
            // 
            // ToolStripMenuZapiszProj
            // 
            this.ToolStripMenuZapiszProj.Name = "ToolStripMenuZapiszProj";
            this.ToolStripMenuZapiszProj.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuZapiszProj.Text = "&Zapisz projekt";
            this.ToolStripMenuZapiszProj.Click += new System.EventHandler(this.ToolStripMenuZapiszProj_Click);
            // 
            // ToolStripMenuZapiszJakoProj
            // 
            this.ToolStripMenuZapiszJakoProj.Name = "ToolStripMenuZapiszJakoProj";
            this.ToolStripMenuZapiszJakoProj.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuZapiszJakoProj.Text = "Z&apisz projekt jako";
            this.ToolStripMenuZapiszJakoProj.Click += new System.EventHandler(this.ToolStripMenuZapiszJakoProj_Click);
            // 
            // ToolStripMenuWyjscie
            // 
            this.ToolStripMenuWyjscie.Name = "ToolStripMenuWyjscie";
            this.ToolStripMenuWyjscie.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuWyjscie.Text = "&Wyjście";
            this.ToolStripMenuWyjscie.Click += new System.EventHandler(this.ToolStripMenuWyjscie_Click);
            // 
            // raportyToolStripMenuItem
            // 
            this.raportyToolStripMenuItem.Name = "raportyToolStripMenuItem";
            this.raportyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.raportyToolStripMenuItem.Text = "&Raporty";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalibracjaToolStripMenuItem,
            this.przelicznikiToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.opcjeToolStripMenuItem.Text = "&Ustawienia";
            // 
            // kalibracjaToolStripMenuItem
            // 
            this.kalibracjaToolStripMenuItem.Name = "kalibracjaToolStripMenuItem";
            this.kalibracjaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.kalibracjaToolStripMenuItem.Text = "&Kalibracja";
            // 
            // przelicznikiToolStripMenuItem
            // 
            this.przelicznikiToolStripMenuItem.Name = "przelicznikiToolStripMenuItem";
            this.przelicznikiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.przelicznikiToolStripMenuItem.Text = "&Przeliczniki";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentacjaToolStripMenuItem,
            this.oProgramieToolStripMenuItem1});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.oProgramieToolStripMenuItem.Text = "Pomo&c";
            // 
            // dokumentacjaToolStripMenuItem
            // 
            this.dokumentacjaToolStripMenuItem.Name = "dokumentacjaToolStripMenuItem";
            this.dokumentacjaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dokumentacjaToolStripMenuItem.Text = "&Dokumentacja";
            // 
            // oProgramieToolStripMenuItem1
            // 
            this.oProgramieToolStripMenuItem1.Name = "oProgramieToolStripMenuItem1";
            this.oProgramieToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.oProgramieToolStripMenuItem1.Text = "&O programie";
            // 
            // DaneProjektu
            // 
            this.DaneProjektu.Controls.Add(this.LabelDataRozp);
            this.DaneProjektu.Controls.Add(this.dateTimePicker1);
            this.DaneProjektu.Controls.Add(this.button1);
            this.DaneProjektu.Controls.Add(this.LabelNazwaProjektu);
            this.DaneProjektu.Controls.Add(this.TextBoxNazwaProjektu);
            this.DaneProjektu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DaneProjektu.Location = new System.Drawing.Point(22, 42);
            this.DaneProjektu.Name = "DaneProjektu";
            this.DaneProjektu.Size = new System.Drawing.Size(503, 150);
            this.DaneProjektu.TabIndex = 1;
            this.DaneProjektu.TabStop = false;
            this.DaneProjektu.Text = "Dane projektu";
            // 
            // LabelDataRozp
            // 
            this.LabelDataRozp.AutoSize = true;
            this.LabelDataRozp.Location = new System.Drawing.Point(6, 74);
            this.LabelDataRozp.Name = "LabelDataRozp";
            this.LabelDataRozp.Size = new System.Drawing.Size(133, 16);
            this.LabelDataRozp.TabIndex = 4;
            this.LabelDataRozp.Text = "Data rozpoczęcia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Więcej szczegółów";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LabelNazwaProjektu
            // 
            this.LabelNazwaProjektu.AutoSize = true;
            this.LabelNazwaProjektu.Location = new System.Drawing.Point(6, 30);
            this.LabelNazwaProjektu.Name = "LabelNazwaProjektu";
            this.LabelNazwaProjektu.Size = new System.Drawing.Size(118, 16);
            this.LabelNazwaProjektu.TabIndex = 1;
            this.LabelNazwaProjektu.Text = "Nazwa projektu:";
            // 
            // TextBoxNazwaProjektu
            // 
            this.TextBoxNazwaProjektu.Location = new System.Drawing.Point(6, 49);
            this.TextBoxNazwaProjektu.Name = "TextBoxNazwaProjektu";
            this.TextBoxNazwaProjektu.Size = new System.Drawing.Size(462, 22);
            this.TextBoxNazwaProjektu.TabIndex = 0;
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 784);
            this.Controls.Add(this.DaneProjektu);
            this.Controls.Add(this.PasekMenu);
            this.MainMenuStrip = this.PasekMenu;
            this.Name = "OknoGlowne";
            this.Text = "Aplikacja wspomagająca szacowanie pracochłonności wytwarzania oprogramowania";
            this.PasekMenu.ResumeLayout(false);
            this.PasekMenu.PerformLayout();
            this.DaneProjektu.ResumeLayout(false);
            this.DaneProjektu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip PasekMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuNowyProj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuZapiszProj;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuWyjscie;
        private System.Windows.Forms.ToolStripMenuItem dokumentacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuOtworzProj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuZapiszJakoProj;
        private System.Windows.Forms.ToolStripMenuItem raportyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalibracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przelicznikiToolStripMenuItem;
        private System.Windows.Forms.GroupBox DaneProjektu;
        private System.Windows.Forms.Label LabelNazwaProjektu;
        private System.Windows.Forms.TextBox TextBoxNazwaProjektu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelDataRozp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

