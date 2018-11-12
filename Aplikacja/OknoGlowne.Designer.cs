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
            this.ToolStripMenuPlik = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuNowyProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuOtworzProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuZapiszProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuZapiszJakoProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuWyjscie = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuRaporty = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuUstawienia = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuKalibracja = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuPrzeliczniki = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuDokumentacja = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuOProgramie = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ToolStripMenuPlik,
            this.ToolStripMenuRaporty,
            this.ToolStripMenuUstawienia,
            this.ToolStripMenuPomoc});
            this.PasekMenu.Location = new System.Drawing.Point(0, 0);
            this.PasekMenu.Name = "PasekMenu";
            this.PasekMenu.Size = new System.Drawing.Size(1321, 24);
            this.PasekMenu.TabIndex = 0;
            this.PasekMenu.Text = "Pasek Menu";
            // 
            // ToolStripMenuPlik
            // 
            this.ToolStripMenuPlik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuNowyProj,
            this.ToolStripMenuOtworzProj,
            this.ToolStripMenuZapiszProj,
            this.ToolStripMenuZapiszJakoProj,
            this.ToolStripMenuWyjscie});
            this.ToolStripMenuPlik.Name = "ToolStripMenuPlik";
            this.ToolStripMenuPlik.Size = new System.Drawing.Size(38, 20);
            this.ToolStripMenuPlik.Text = "&Plik";
            // 
            // ToolStripMenuNowyProj
            // 
            this.ToolStripMenuNowyProj.Name = "ToolStripMenuNowyProj";
            this.ToolStripMenuNowyProj.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuNowyProj.Text = "&Nowy projekt";
            this.ToolStripMenuNowyProj.Click += new System.EventHandler(this.ToolStripMenuNowyProj_Click);
            // 
            // ToolStripMenuOtworzProj
            // 
            this.ToolStripMenuOtworzProj.Name = "ToolStripMenuOtworzProj";
            this.ToolStripMenuOtworzProj.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuOtworzProj.Text = "&Otwórz projekt";
            this.ToolStripMenuOtworzProj.Click += new System.EventHandler(this.ToolStripMenuOtworzProj_Click);
            // 
            // ToolStripMenuZapiszProj
            // 
            this.ToolStripMenuZapiszProj.Name = "ToolStripMenuZapiszProj";
            this.ToolStripMenuZapiszProj.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuZapiszProj.Text = "&Zapisz projekt";
            this.ToolStripMenuZapiszProj.Click += new System.EventHandler(this.ToolStripMenuZapiszProj_Click);
            // 
            // ToolStripMenuZapiszJakoProj
            // 
            this.ToolStripMenuZapiszJakoProj.Name = "ToolStripMenuZapiszJakoProj";
            this.ToolStripMenuZapiszJakoProj.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuZapiszJakoProj.Text = "Z&apisz projekt jako";
            this.ToolStripMenuZapiszJakoProj.Click += new System.EventHandler(this.ToolStripMenuZapiszJakoProj_Click);
            // 
            // ToolStripMenuWyjscie
            // 
            this.ToolStripMenuWyjscie.Name = "ToolStripMenuWyjscie";
            this.ToolStripMenuWyjscie.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuWyjscie.Text = "&Wyjście";
            this.ToolStripMenuWyjscie.Click += new System.EventHandler(this.ToolStripMenuWyjscie_Click);
            // 
            // ToolStripMenuRaporty
            // 
            this.ToolStripMenuRaporty.Name = "ToolStripMenuRaporty";
            this.ToolStripMenuRaporty.Size = new System.Drawing.Size(60, 20);
            this.ToolStripMenuRaporty.Text = "&Raporty";
            // 
            // ToolStripMenuUstawienia
            // 
            this.ToolStripMenuUstawienia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuKalibracja,
            this.ToolStripMenuPrzeliczniki});
            this.ToolStripMenuUstawienia.Name = "ToolStripMenuUstawienia";
            this.ToolStripMenuUstawienia.Size = new System.Drawing.Size(76, 20);
            this.ToolStripMenuUstawienia.Text = "&Ustawienia";
            // 
            // ToolStripMenuKalibracja
            // 
            this.ToolStripMenuKalibracja.Name = "ToolStripMenuKalibracja";
            this.ToolStripMenuKalibracja.Size = new System.Drawing.Size(132, 22);
            this.ToolStripMenuKalibracja.Text = "&Kalibracja";
            this.ToolStripMenuKalibracja.Click += new System.EventHandler(this.ToolStripMenuKalibracja_Click);
            // 
            // ToolStripMenuPrzeliczniki
            // 
            this.ToolStripMenuPrzeliczniki.Name = "ToolStripMenuPrzeliczniki";
            this.ToolStripMenuPrzeliczniki.Size = new System.Drawing.Size(132, 22);
            this.ToolStripMenuPrzeliczniki.Text = "&Przeliczniki";
            this.ToolStripMenuPrzeliczniki.Click += new System.EventHandler(this.ToolStripMenuPrzeliczniki_Click);
            // 
            // ToolStripMenuPomoc
            // 
            this.ToolStripMenuPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuDokumentacja,
            this.ToolStripMenuOProgramie});
            this.ToolStripMenuPomoc.Name = "ToolStripMenuPomoc";
            this.ToolStripMenuPomoc.Size = new System.Drawing.Size(57, 20);
            this.ToolStripMenuPomoc.Text = "Pomo&c";
            // 
            // ToolStripMenuDokumentacja
            // 
            this.ToolStripMenuDokumentacja.Name = "ToolStripMenuDokumentacja";
            this.ToolStripMenuDokumentacja.Size = new System.Drawing.Size(151, 22);
            this.ToolStripMenuDokumentacja.Text = "&Dokumentacja";
            this.ToolStripMenuDokumentacja.Click += new System.EventHandler(this.ToolStripMenuDokumentacja_Click);
            // 
            // ToolStripMenuOProgramie
            // 
            this.ToolStripMenuOProgramie.Name = "ToolStripMenuOProgramie";
            this.ToolStripMenuOProgramie.Size = new System.Drawing.Size(151, 22);
            this.ToolStripMenuOProgramie.Text = "&O programie";
            this.ToolStripMenuOProgramie.Click += new System.EventHandler(this.ToolStripMenuOProgramie_Click);
            // 
            // DaneProjektu
            // 
            this.DaneProjektu.Controls.Add(this.LabelDataRozp);
            this.DaneProjektu.Controls.Add(this.dateTimePicker1);
            this.DaneProjektu.Controls.Add(this.button1);
            this.DaneProjektu.Controls.Add(this.LabelNazwaProjektu);
            this.DaneProjektu.Controls.Add(this.TextBoxNazwaProjektu);
            this.DaneProjektu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DaneProjektu.Location = new System.Drawing.Point(12, 39);
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuPlik;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuNowyProj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuZapiszProj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuUstawienia;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuPomoc;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuWyjscie;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuDokumentacja;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuOProgramie;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuOtworzProj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuZapiszJakoProj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuRaporty;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuKalibracja;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuPrzeliczniki;
        private System.Windows.Forms.GroupBox DaneProjektu;
        private System.Windows.Forms.Label LabelNazwaProjektu;
        private System.Windows.Forms.TextBox TextBoxNazwaProjektu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelDataRozp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

