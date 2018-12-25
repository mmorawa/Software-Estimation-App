namespace Aplikacja
{
    partial class OknoDaneProjektu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoDaneProjektu));
            this.ButtonAnuluj = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.GroupBoxSzczDaneProjektu = new System.Windows.Forms.GroupBox();
            this.CheckBoxDomyslne = new System.Windows.Forms.CheckBox();
            this.RichTextBoxOpisProjektu = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSzacujacy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxTelefon = new System.Windows.Forms.TextBox();
            this.TextBoxAdres = new System.Windows.Forms.TextBox();
            this.TextBoxNazwaFirmy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxKierownikProjektu = new System.Windows.Forms.TextBox();
            this.GroupBoxSzczDaneProjektu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAnuluj
            // 
            this.ButtonAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAnuluj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAnuluj.Location = new System.Drawing.Point(267, 679);
            this.ButtonAnuluj.Name = "ButtonAnuluj";
            this.ButtonAnuluj.Size = new System.Drawing.Size(104, 27);
            this.ButtonAnuluj.TabIndex = 1;
            this.ButtonAnuluj.Text = "Anuluj";
            this.ButtonAnuluj.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOk.Location = new System.Drawing.Point(107, 679);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(104, 27);
            this.ButtonOk.TabIndex = 0;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSzczDaneProjektu
            // 
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.CheckBoxDomyslne);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.RichTextBoxOpisProjektu);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.label7);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.label2);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.TextBoxSzacujacy);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.label6);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.TextBoxEmail);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.label5);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.label4);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.TextBoxTelefon);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.TextBoxAdres);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.TextBoxNazwaFirmy);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.label3);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.label1);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.TextBoxKierownikProjektu);
            this.GroupBoxSzczDaneProjektu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxSzczDaneProjektu.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxSzczDaneProjektu.Name = "GroupBoxSzczDaneProjektu";
            this.GroupBoxSzczDaneProjektu.Size = new System.Drawing.Size(489, 661);
            this.GroupBoxSzczDaneProjektu.TabIndex = 14;
            this.GroupBoxSzczDaneProjektu.TabStop = false;
            this.GroupBoxSzczDaneProjektu.Text = "Szczegółowe dane projektu";
            // 
            // CheckBoxDomyslne
            // 
            this.CheckBoxDomyslne.AutoSize = true;
            this.CheckBoxDomyslne.Location = new System.Drawing.Point(274, 21);
            this.CheckBoxDomyslne.Name = "CheckBoxDomyslne";
            this.CheckBoxDomyslne.Size = new System.Drawing.Size(183, 20);
            this.CheckBoxDomyslne.TabIndex = 2;
            this.CheckBoxDomyslne.Text = "Użyj danych domyślnych";
            this.CheckBoxDomyslne.UseVisualStyleBackColor = true;
            this.CheckBoxDomyslne.Click += new System.EventHandler(this.CheckBoxDomyslne_Click);
            // 
            // RichTextBoxOpisProjektu
            // 
            this.RichTextBoxOpisProjektu.Location = new System.Drawing.Point(13, 318);
            this.RichTextBoxOpisProjektu.MaxLength = 2000;
            this.RichTextBoxOpisProjektu.Name = "RichTextBoxOpisProjektu";
            this.RichTextBoxOpisProjektu.Size = new System.Drawing.Size(459, 326);
            this.RichTextBoxOpisProjektu.TabIndex = 9;
            this.RichTextBoxOpisProjektu.Text = "";
            this.RichTextBoxOpisProjektu.TextChanged += new System.EventHandler(this.RichTextBoxOpisProjektu_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Opis projektu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Osoba odpowiedzialna za oszacowanie:";
            // 
            // TextBoxSzacujacy
            // 
            this.TextBoxSzacujacy.Location = new System.Drawing.Point(9, 98);
            this.TextBoxSzacujacy.MaxLength = 50;
            this.TextBoxSzacujacy.Name = "TextBoxSzacujacy";
            this.TextBoxSzacujacy.Size = new System.Drawing.Size(462, 22);
            this.TextBoxSzacujacy.TabIndex = 4;
            this.TextBoxSzacujacy.TextChanged += new System.EventHandler(this.TextBoxSzacujacy_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-Mail:";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(9, 274);
            this.TextBoxEmail.MaxLength = 50;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(462, 22);
            this.TextBoxEmail.TabIndex = 8;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefon/Fax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres:";
            // 
            // TextBoxTelefon
            // 
            this.TextBoxTelefon.Location = new System.Drawing.Point(9, 230);
            this.TextBoxTelefon.MaxLength = 50;
            this.TextBoxTelefon.Name = "TextBoxTelefon";
            this.TextBoxTelefon.Size = new System.Drawing.Size(462, 22);
            this.TextBoxTelefon.TabIndex = 7;
            this.TextBoxTelefon.TextChanged += new System.EventHandler(this.TextBoxTelefon_TextChanged);
            // 
            // TextBoxAdres
            // 
            this.TextBoxAdres.Location = new System.Drawing.Point(12, 186);
            this.TextBoxAdres.MaxLength = 50;
            this.TextBoxAdres.Name = "TextBoxAdres";
            this.TextBoxAdres.Size = new System.Drawing.Size(462, 22);
            this.TextBoxAdres.TabIndex = 6;
            this.TextBoxAdres.TextChanged += new System.EventHandler(this.TextBoxAdres_TextChanged);
            // 
            // TextBoxNazwaFirmy
            // 
            this.TextBoxNazwaFirmy.Location = new System.Drawing.Point(9, 142);
            this.TextBoxNazwaFirmy.MaxLength = 50;
            this.TextBoxNazwaFirmy.Name = "TextBoxNazwaFirmy";
            this.TextBoxNazwaFirmy.Size = new System.Drawing.Size(462, 22);
            this.TextBoxNazwaFirmy.TabIndex = 5;
            this.TextBoxNazwaFirmy.TextChanged += new System.EventHandler(this.TextBoxNazwaFirmy_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nazwa firmy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kierownik projektu:";
            // 
            // TextBoxKierownikProjektu
            // 
            this.TextBoxKierownikProjektu.Location = new System.Drawing.Point(9, 54);
            this.TextBoxKierownikProjektu.MaxLength = 50;
            this.TextBoxKierownikProjektu.Name = "TextBoxKierownikProjektu";
            this.TextBoxKierownikProjektu.Size = new System.Drawing.Size(462, 22);
            this.TextBoxKierownikProjektu.TabIndex = 3;
            this.TextBoxKierownikProjektu.TextChanged += new System.EventHandler(this.TextBoxKierownikProjektu_TextChanged);
            // 
            // OknoDaneProjektu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 718);
            this.Controls.Add(this.GroupBoxSzczDaneProjektu);
            this.Controls.Add(this.ButtonAnuluj);
            this.Controls.Add(this.ButtonOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OknoDaneProjektu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dane projektu";
            this.GroupBoxSzczDaneProjektu.ResumeLayout(false);
            this.GroupBoxSzczDaneProjektu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAnuluj;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.GroupBox GroupBoxSzczDaneProjektu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxKierownikProjektu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxTelefon;
        private System.Windows.Forms.TextBox TextBoxAdres;
        private System.Windows.Forms.TextBox TextBoxNazwaFirmy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSzacujacy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.RichTextBox RichTextBoxOpisProjektu;
        private System.Windows.Forms.CheckBox CheckBoxDomyslne;
    }
}