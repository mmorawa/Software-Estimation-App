namespace Aplikacja
{
    partial class OknoPodgladRaportow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoPodgladRaportow));
            this.PodgladRaportu = new MigraDoc.Rendering.Forms.DocumentPreview();
            this.ButtonDrukuj = new System.Windows.Forms.Button();
            this.ButtonNastepna = new System.Windows.Forms.Button();
            this.ButtonPoprzednia = new System.Windows.Forms.Button();
            this.ButtonUstawieniaDruk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelPowiekszenie = new System.Windows.Forms.Label();
            this.LabelStrona = new System.Windows.Forms.Label();
            this.ButtonPomniejsz = new System.Windows.Forms.Button();
            this.ButtonPowieksz = new System.Windows.Forms.Button();
            this.ButtonEksportRTF = new System.Windows.Forms.Button();
            this.ButtonEksportPDF = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PodgladRaportu
            // 
            this.PodgladRaportu.AutoSize = true;
            this.PodgladRaportu.Ddl = null;
            this.PodgladRaportu.DesktopColor = System.Drawing.SystemColors.ControlDark;
            this.PodgladRaportu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PodgladRaportu.Document = null;
            this.PodgladRaportu.Location = new System.Drawing.Point(0, 0);
            this.PodgladRaportu.Name = "PodgladRaportu";
            this.PodgladRaportu.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.PodgladRaportu.Page = 0;
            this.PodgladRaportu.PageColor = System.Drawing.Color.GhostWhite;
            this.PodgladRaportu.PageSize = new System.Drawing.Size(595, 842);
            this.PodgladRaportu.PrivateFonts = null;
            this.PodgladRaportu.Size = new System.Drawing.Size(877, 711);
            this.PodgladRaportu.TabIndex = 1;
            this.PodgladRaportu.Zoom = MigraDoc.Rendering.Forms.Zoom.Percent100;
            this.PodgladRaportu.ZoomPercent = 100;
            // 
            // ButtonDrukuj
            // 
            this.ButtonDrukuj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDrukuj.Location = new System.Drawing.Point(12, 13);
            this.ButtonDrukuj.Name = "ButtonDrukuj";
            this.ButtonDrukuj.Size = new System.Drawing.Size(91, 27);
            this.ButtonDrukuj.TabIndex = 0;
            this.ButtonDrukuj.Text = "Drukuj";
            this.ToolTip.SetToolTip(this.ButtonDrukuj, "Wydrukuj raport");
            this.ButtonDrukuj.UseVisualStyleBackColor = true;
            this.ButtonDrukuj.Click += new System.EventHandler(this.ButtonDrukuj_Click);
            // 
            // ButtonNastepna
            // 
            this.ButtonNastepna.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonNastepna.Location = new System.Drawing.Point(678, 13);
            this.ButtonNastepna.Name = "ButtonNastepna";
            this.ButtonNastepna.Size = new System.Drawing.Size(35, 27);
            this.ButtonNastepna.TabIndex = 5;
            this.ButtonNastepna.Text = ">>";
            this.ButtonNastepna.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTip.SetToolTip(this.ButtonNastepna, "Przejdź do następnej strony");
            this.ButtonNastepna.UseVisualStyleBackColor = true;
            this.ButtonNastepna.Click += new System.EventHandler(this.ButtonNastepna_Click);
            // 
            // ButtonPoprzednia
            // 
            this.ButtonPoprzednia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPoprzednia.Location = new System.Drawing.Point(585, 13);
            this.ButtonPoprzednia.Name = "ButtonPoprzednia";
            this.ButtonPoprzednia.Size = new System.Drawing.Size(35, 27);
            this.ButtonPoprzednia.TabIndex = 4;
            this.ButtonPoprzednia.Text = "<<";
            this.ButtonPoprzednia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.ButtonPoprzednia, "Przejdź do poprzedniej strony");
            this.ButtonPoprzednia.UseVisualStyleBackColor = true;
            this.ButtonPoprzednia.Click += new System.EventHandler(this.ButtonPoprzednia_Click);
            // 
            // ButtonUstawieniaDruk
            // 
            this.ButtonUstawieniaDruk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonUstawieniaDruk.Location = new System.Drawing.Point(109, 13);
            this.ButtonUstawieniaDruk.Name = "ButtonUstawieniaDruk";
            this.ButtonUstawieniaDruk.Size = new System.Drawing.Size(173, 27);
            this.ButtonUstawieniaDruk.TabIndex = 1;
            this.ButtonUstawieniaDruk.Text = "Ustawienia drukowania";
            this.ToolTip.SetToolTip(this.ButtonUstawieniaDruk, "Zmień ustawienia drukowania");
            this.ButtonUstawieniaDruk.UseVisualStyleBackColor = true;
            this.ButtonUstawieniaDruk.Click += new System.EventHandler(this.ButtonUstawieniaDruk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelPowiekszenie);
            this.panel1.Controls.Add(this.LabelStrona);
            this.panel1.Controls.Add(this.ButtonPomniejsz);
            this.panel1.Controls.Add(this.ButtonPowieksz);
            this.panel1.Controls.Add(this.ButtonEksportRTF);
            this.panel1.Controls.Add(this.ButtonEksportPDF);
            this.panel1.Controls.Add(this.ButtonDrukuj);
            this.panel1.Controls.Add(this.ButtonNastepna);
            this.panel1.Controls.Add(this.ButtonPoprzednia);
            this.panel1.Controls.Add(this.ButtonUstawieniaDruk);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 50);
            this.panel1.TabIndex = 6;
            // 
            // LabelPowiekszenie
            // 
            this.LabelPowiekszenie.AutoSize = true;
            this.LabelPowiekszenie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPowiekszenie.Location = new System.Drawing.Point(772, 18);
            this.LabelPowiekszenie.Name = "LabelPowiekszenie";
            this.LabelPowiekszenie.Size = new System.Drawing.Size(46, 17);
            this.LabelPowiekszenie.TabIndex = 11;
            this.LabelPowiekszenie.Text = "label2";
            // 
            // LabelStrona
            // 
            this.LabelStrona.AutoSize = true;
            this.LabelStrona.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelStrona.Location = new System.Drawing.Point(626, 18);
            this.LabelStrona.Name = "LabelStrona";
            this.LabelStrona.Size = new System.Drawing.Size(46, 17);
            this.LabelStrona.TabIndex = 10;
            this.LabelStrona.Text = "label1";
            // 
            // ButtonPomniejsz
            // 
            this.ButtonPomniejsz.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPomniejsz.Location = new System.Drawing.Point(731, 13);
            this.ButtonPomniejsz.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ButtonPomniejsz.Name = "ButtonPomniejsz";
            this.ButtonPomniejsz.Size = new System.Drawing.Size(35, 27);
            this.ButtonPomniejsz.TabIndex = 6;
            this.ButtonPomniejsz.Text = "-";
            this.ToolTip.SetToolTip(this.ButtonPomniejsz, "Pomniejsz");
            this.ButtonPomniejsz.UseVisualStyleBackColor = true;
            this.ButtonPomniejsz.Click += new System.EventHandler(this.ButtonPomniejsz_Click);
            // 
            // ButtonPowieksz
            // 
            this.ButtonPowieksz.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPowieksz.Location = new System.Drawing.Point(824, 13);
            this.ButtonPowieksz.Name = "ButtonPowieksz";
            this.ButtonPowieksz.Size = new System.Drawing.Size(35, 27);
            this.ButtonPowieksz.TabIndex = 7;
            this.ButtonPowieksz.Text = "+";
            this.ButtonPowieksz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip.SetToolTip(this.ButtonPowieksz, "Powiększ");
            this.ButtonPowieksz.UseVisualStyleBackColor = true;
            this.ButtonPowieksz.Click += new System.EventHandler(this.ButtonPowieksz_Click);
            // 
            // ButtonEksportRTF
            // 
            this.ButtonEksportRTF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEksportRTF.Location = new System.Drawing.Point(433, 13);
            this.ButtonEksportRTF.Name = "ButtonEksportRTF";
            this.ButtonEksportRTF.Size = new System.Drawing.Size(131, 27);
            this.ButtonEksportRTF.TabIndex = 3;
            this.ButtonEksportRTF.Text = "Eksportuj do RTF";
            this.ToolTip.SetToolTip(this.ButtonEksportRTF, "Wyeksportuj raport do pliku formatu RTF");
            this.ButtonEksportRTF.UseVisualStyleBackColor = true;
            this.ButtonEksportRTF.Click += new System.EventHandler(this.ButtonEksportRTF_Click);
            // 
            // ButtonEksportPDF
            // 
            this.ButtonEksportPDF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEksportPDF.Location = new System.Drawing.Point(288, 13);
            this.ButtonEksportPDF.Name = "ButtonEksportPDF";
            this.ButtonEksportPDF.Size = new System.Drawing.Size(139, 27);
            this.ButtonEksportPDF.TabIndex = 2;
            this.ButtonEksportPDF.Text = "Eksportuj do PDF";
            this.ToolTip.SetToolTip(this.ButtonEksportPDF, "Wyeksportuj raport do pliku formatu PDF");
            this.ButtonEksportPDF.UseVisualStyleBackColor = true;
            this.ButtonEksportPDF.Click += new System.EventHandler(this.ButtonEksportPDF_Click);
            // 
            // OknoPodgladRaportow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PodgladRaportu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OknoPodgladRaportow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podgląd wydruku raportu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MigraDoc.Rendering.Forms.DocumentPreview PodgladRaportu;
        private System.Windows.Forms.Button ButtonDrukuj;
        private System.Windows.Forms.Button ButtonNastepna;
        private System.Windows.Forms.Button ButtonPoprzednia;
        private System.Windows.Forms.Button ButtonUstawieniaDruk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonEksportRTF;
        private System.Windows.Forms.Button ButtonEksportPDF;
        private System.Windows.Forms.Button ButtonPomniejsz;
        private System.Windows.Forms.Button ButtonPowieksz;
        private System.Windows.Forms.Label LabelPowiekszenie;
        private System.Windows.Forms.Label LabelStrona;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}