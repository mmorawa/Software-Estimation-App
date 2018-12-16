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
            this.PodgladRaportu = new MigraDoc.Rendering.Forms.DocumentPreview();
            this.ButtonDrukuj = new System.Windows.Forms.Button();
            this.ButtonNastepna = new System.Windows.Forms.Button();
            this.ButtonPoprzednia = new System.Windows.Forms.Button();
            this.ButtonUstawieniaDruk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.PodgladRaportu.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.PodgladRaportu.Page = 0;
            this.PodgladRaportu.PageColor = System.Drawing.Color.GhostWhite;
            this.PodgladRaportu.PageSize = new System.Drawing.Size(595, 842);
            this.PodgladRaportu.PrivateFonts = null;
            this.PodgladRaportu.Size = new System.Drawing.Size(828, 541);
            this.PodgladRaportu.TabIndex = 1;
            this.PodgladRaportu.Zoom = MigraDoc.Rendering.Forms.Zoom.OriginalSize;
            this.PodgladRaportu.ZoomPercent = 75;
            // 
            // ButtonDrukuj
            // 
            this.ButtonDrukuj.Location = new System.Drawing.Point(12, 15);
            this.ButtonDrukuj.Name = "ButtonDrukuj";
            this.ButtonDrukuj.Size = new System.Drawing.Size(75, 23);
            this.ButtonDrukuj.TabIndex = 2;
            this.ButtonDrukuj.Text = "Drukuj";
            this.ButtonDrukuj.UseVisualStyleBackColor = true;
            this.ButtonDrukuj.Click += new System.EventHandler(this.ButtonDrukuj_Click);
            // 
            // ButtonNastepna
            // 
            this.ButtonNastepna.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonNastepna.Location = new System.Drawing.Point(468, 15);
            this.ButtonNastepna.Name = "ButtonNastepna";
            this.ButtonNastepna.Size = new System.Drawing.Size(75, 23);
            this.ButtonNastepna.TabIndex = 3;
            this.ButtonNastepna.Text = "Następna";
            this.ButtonNastepna.UseVisualStyleBackColor = true;
            this.ButtonNastepna.Click += new System.EventHandler(this.ButtonNastepna_Click);
            // 
            // ButtonPoprzednia
            // 
            this.ButtonPoprzednia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPoprzednia.Location = new System.Drawing.Point(346, 15);
            this.ButtonPoprzednia.Name = "ButtonPoprzednia";
            this.ButtonPoprzednia.Size = new System.Drawing.Size(98, 23);
            this.ButtonPoprzednia.TabIndex = 4;
            this.ButtonPoprzednia.Text = "Poprzednia";
            this.ButtonPoprzednia.UseVisualStyleBackColor = true;
            this.ButtonPoprzednia.Click += new System.EventHandler(this.ButtonPoprzednia_Click);
            // 
            // ButtonUstawieniaDruk
            // 
            this.ButtonUstawieniaDruk.Location = new System.Drawing.Point(104, 15);
            this.ButtonUstawieniaDruk.Name = "ButtonUstawieniaDruk";
            this.ButtonUstawieniaDruk.Size = new System.Drawing.Size(134, 23);
            this.ButtonUstawieniaDruk.TabIndex = 5;
            this.ButtonUstawieniaDruk.Text = "Ustawienia drukowania";
            this.ButtonUstawieniaDruk.UseVisualStyleBackColor = true;
            this.ButtonUstawieniaDruk.Click += new System.EventHandler(this.ButtonUstawieniaDruk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonDrukuj);
            this.panel1.Controls.Add(this.ButtonNastepna);
            this.panel1.Controls.Add(this.ButtonPoprzednia);
            this.panel1.Controls.Add(this.ButtonUstawieniaDruk);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 79);
            this.panel1.TabIndex = 6;
            // 
            // OknoPodgladRaportow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PodgladRaportu);
            this.Name = "OknoPodgladRaportow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podgląd Raportu";
            this.panel1.ResumeLayout(false);
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
    }
}