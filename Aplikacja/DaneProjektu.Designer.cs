namespace Aplikacja
{
    partial class DaneProjektu
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
            this.LabelDataRozp = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LabelNazwaProjektu = new System.Windows.Forms.Label();
            this.TextBoxNazwaProjektu = new System.Windows.Forms.TextBox();
            this.GroupBoxSzczDaneProjektu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAnuluj
            // 
            this.ButtonAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAnuluj.Location = new System.Drawing.Point(357, 627);
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
            this.ButtonOk.Location = new System.Drawing.Point(197, 627);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(104, 27);
            this.ButtonOk.TabIndex = 12;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSzczDaneProjektu
            // 
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.LabelDataRozp);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.DateTimePicker);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.LabelNazwaProjektu);
            this.GroupBoxSzczDaneProjektu.Controls.Add(this.TextBoxNazwaProjektu);
            this.GroupBoxSzczDaneProjektu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxSzczDaneProjektu.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxSzczDaneProjektu.Name = "GroupBoxSzczDaneProjektu";
            this.GroupBoxSzczDaneProjektu.Size = new System.Drawing.Size(621, 589);
            this.GroupBoxSzczDaneProjektu.TabIndex = 14;
            this.GroupBoxSzczDaneProjektu.TabStop = false;
            this.GroupBoxSzczDaneProjektu.Text = "Szczegółowe dane projektu";
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
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(6, 93);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DateTimePicker.TabIndex = 3;
            this.DateTimePicker.Value = new System.DateTime(2018, 11, 15, 14, 35, 14, 0);
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
            // DaneProjektu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 718);
            this.Controls.Add(this.GroupBoxSzczDaneProjektu);
            this.Controls.Add(this.ButtonAnuluj);
            this.Controls.Add(this.ButtonOk);
            this.Name = "DaneProjektu";
            this.Text = "Dane projektu";
            this.GroupBoxSzczDaneProjektu.ResumeLayout(false);
            this.GroupBoxSzczDaneProjektu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAnuluj;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.GroupBox GroupBoxSzczDaneProjektu;
        private System.Windows.Forms.Label LabelDataRozp;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label LabelNazwaProjektu;
        private System.Windows.Forms.TextBox TextBoxNazwaProjektu;
    }
}