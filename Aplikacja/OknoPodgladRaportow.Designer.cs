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
            this.documentPreview1 = new MigraDoc.Rendering.Forms.DocumentPreview();
            this.ButtonDrukuj = new System.Windows.Forms.Button();
            this.ButtonNastepna = new System.Windows.Forms.Button();
            this.ButtonPoprzednia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // documentPreview1
            // 
            this.documentPreview1.Ddl = null;
            this.documentPreview1.DesktopColor = System.Drawing.SystemColors.ControlDark;
            this.documentPreview1.Document = null;
            this.documentPreview1.Location = new System.Drawing.Point(12, 62);
            this.documentPreview1.Name = "documentPreview1";
            this.documentPreview1.Page = 0;
            this.documentPreview1.PageColor = System.Drawing.Color.GhostWhite;
            this.documentPreview1.PageSize = new System.Drawing.Size(595, 842);
            this.documentPreview1.PrivateFonts = null;
            this.documentPreview1.Size = new System.Drawing.Size(796, 467);
            this.documentPreview1.TabIndex = 1;
            this.documentPreview1.ZoomPercent = 60;
            // 
            // ButtonDrukuj
            // 
            this.ButtonDrukuj.Location = new System.Drawing.Point(12, 12);
            this.ButtonDrukuj.Name = "ButtonDrukuj";
            this.ButtonDrukuj.Size = new System.Drawing.Size(75, 23);
            this.ButtonDrukuj.TabIndex = 2;
            this.ButtonDrukuj.Text = "Drukuj";
            this.ButtonDrukuj.UseVisualStyleBackColor = true;
            // 
            // ButtonNastepna
            // 
            this.ButtonNastepna.Location = new System.Drawing.Point(426, 12);
            this.ButtonNastepna.Name = "ButtonNastepna";
            this.ButtonNastepna.Size = new System.Drawing.Size(75, 23);
            this.ButtonNastepna.TabIndex = 3;
            this.ButtonNastepna.Text = "Następna";
            this.ButtonNastepna.UseVisualStyleBackColor = true;
            this.ButtonNastepna.Click += new System.EventHandler(this.ButtonNastepna_Click);
            // 
            // ButtonPoprzednia
            // 
            this.ButtonPoprzednia.Location = new System.Drawing.Point(345, 12);
            this.ButtonPoprzednia.Name = "ButtonPoprzednia";
            this.ButtonPoprzednia.Size = new System.Drawing.Size(75, 23);
            this.ButtonPoprzednia.TabIndex = 4;
            this.ButtonPoprzednia.Text = "Poprzednia";
            this.ButtonPoprzednia.UseVisualStyleBackColor = true;
            this.ButtonPoprzednia.Click += new System.EventHandler(this.ButtonPoprzednia_Click);
            // 
            // OknoPodgladRaportow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 541);
            this.Controls.Add(this.ButtonPoprzednia);
            this.Controls.Add(this.ButtonNastepna);
            this.Controls.Add(this.ButtonDrukuj);
            this.Controls.Add(this.documentPreview1);
            this.Name = "OknoPodgladRaportow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podgląd Raportu";
            this.ResumeLayout(false);

        }

        #endregion
        private MigraDoc.Rendering.Forms.DocumentPreview documentPreview1;
        private System.Windows.Forms.Button ButtonDrukuj;
        private System.Windows.Forms.Button ButtonNastepna;
        private System.Windows.Forms.Button ButtonPoprzednia;
    }
}