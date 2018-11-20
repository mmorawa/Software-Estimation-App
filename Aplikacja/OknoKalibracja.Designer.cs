namespace Aplikacja
{
    partial class OknoKalibracja
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
            this.GroupBoxKalibracja = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelDataRozp = new System.Windows.Forms.Label();
            this.NumericUCPnaFP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxD = new System.Windows.Forms.TextBox();
            this.TextBoxC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupBoxCOCOMOII = new System.Windows.Forms.GroupBox();
            this.GroupBoxKalibracja.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUCPnaFP)).BeginInit();
            this.GroupBoxCOCOMOII.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAnuluj
            // 
            this.ButtonAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAnuluj.Location = new System.Drawing.Point(335, 756);
            this.ButtonAnuluj.Name = "ButtonAnuluj";
            this.ButtonAnuluj.Size = new System.Drawing.Size(104, 27);
            this.ButtonAnuluj.TabIndex = 20;
            this.ButtonAnuluj.Text = "Anuluj";
            this.ButtonAnuluj.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOk.Location = new System.Drawing.Point(175, 756);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(104, 27);
            this.ButtonOk.TabIndex = 19;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // GroupBoxKalibracja
            // 
            this.GroupBoxKalibracja.Controls.Add(this.GroupBoxCOCOMOII);
            this.GroupBoxKalibracja.Controls.Add(this.tableLayoutPanel2);
            this.GroupBoxKalibracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxKalibracja.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxKalibracja.Name = "GroupBoxKalibracja";
            this.GroupBoxKalibracja.Size = new System.Drawing.Size(615, 723);
            this.GroupBoxKalibracja.TabIndex = 21;
            this.GroupBoxKalibracja.TabStop = false;
            this.GroupBoxKalibracja.Text = "Kalibracja";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 32);
            this.label10.TabIndex = 36;
            this.label10.Text = "Suma czynników\r\n skali x 0,01";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(324, 32);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(100, 22);
            this.TextBoxB.TabIndex = 35;
            this.TextBoxB.TextChanged += new System.EventHandler(this.TextBoxB_TextChanged);
            // 
            // TextBoxA
            // 
            this.TextBoxA.Location = new System.Drawing.Point(146, 51);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(100, 22);
            this.TextBoxA.TabIndex = 34;
            this.TextBoxA.TextChanged += new System.EventHandler(this.TextBoxA_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "x Rozmiar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Pracochłonność =";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel2.Controls.Add(this.LabelDataRozp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.NumericUCPnaFP, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 44);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(552, 196);
            this.tableLayoutPanel2.TabIndex = 38;
            // 
            // LabelDataRozp
            // 
            this.LabelDataRozp.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.LabelDataRozp, 2);
            this.LabelDataRozp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDataRozp.Location = new System.Drawing.Point(3, 0);
            this.LabelDataRozp.Name = "LabelDataRozp";
            this.LabelDataRozp.Size = new System.Drawing.Size(352, 65);
            this.LabelDataRozp.TabIndex = 4;
            this.LabelDataRozp.Text = "Współczynnik konwersji punktów przypadków użycia na punkty funkcyjne:\r\n";
            this.LabelDataRozp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumericUCPnaFP
            // 
            this.NumericUCPnaFP.DecimalPlaces = 2;
            this.NumericUCPnaFP.Location = new System.Drawing.Point(361, 18);
            this.NumericUCPnaFP.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.NumericUCPnaFP.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.NumericUCPnaFP.Name = "NumericUCPnaFP";
            this.NumericUCPnaFP.Size = new System.Drawing.Size(188, 22);
            this.NumericUCPnaFP.TabIndex = 16;
            this.NumericUCPnaFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUCPnaFP.ThousandsSeparator = true;
            this.NumericUCPnaFP.ValueChanged += new System.EventHandler(this.NumericUCPnaFP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "+ (E - B) x 0,2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxD
            // 
            this.TextBoxD.Location = new System.Drawing.Point(361, 110);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.Size = new System.Drawing.Size(100, 22);
            this.TextBoxD.TabIndex = 42;
            this.TextBoxD.TextChanged += new System.EventHandler(this.TextBoxD_TextChanged);
            // 
            // TextBoxC
            // 
            this.TextBoxC.Location = new System.Drawing.Point(130, 132);
            this.TextBoxC.Name = "TextBoxC";
            this.TextBoxC.Size = new System.Drawing.Size(100, 22);
            this.TextBoxC.TabIndex = 41;
            this.TextBoxC.TextChanged += new System.EventHandler(this.TextBoxC_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "x Pracochłonność";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Harmonogram =";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupBoxCOCOMOII
            // 
            this.GroupBoxCOCOMOII.Controls.Add(this.label5);
            this.GroupBoxCOCOMOII.Controls.Add(this.label3);
            this.GroupBoxCOCOMOII.Controls.Add(this.label6);
            this.GroupBoxCOCOMOII.Controls.Add(this.TextBoxD);
            this.GroupBoxCOCOMOII.Controls.Add(this.TextBoxA);
            this.GroupBoxCOCOMOII.Controls.Add(this.TextBoxC);
            this.GroupBoxCOCOMOII.Controls.Add(this.TextBoxB);
            this.GroupBoxCOCOMOII.Controls.Add(this.label4);
            this.GroupBoxCOCOMOII.Controls.Add(this.label10);
            this.GroupBoxCOCOMOII.Controls.Add(this.label7);
            this.GroupBoxCOCOMOII.Controls.Add(this.label1);
            this.GroupBoxCOCOMOII.Location = new System.Drawing.Point(18, 276);
            this.GroupBoxCOCOMOII.Name = "GroupBoxCOCOMOII";
            this.GroupBoxCOCOMOII.Size = new System.Drawing.Size(578, 255);
            this.GroupBoxCOCOMOII.TabIndex = 44;
            this.GroupBoxCOCOMOII.TabStop = false;
            this.GroupBoxCOCOMOII.Text = "Model COCOMO II";
            // 
            // OknoKalibracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 809);
            this.Controls.Add(this.GroupBoxKalibracja);
            this.Controls.Add(this.ButtonAnuluj);
            this.Controls.Add(this.ButtonOk);
            this.Name = "OknoKalibracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kalibracja";
            this.GroupBoxKalibracja.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUCPnaFP)).EndInit();
            this.GroupBoxCOCOMOII.ResumeLayout(false);
            this.GroupBoxCOCOMOII.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAnuluj;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.GroupBox GroupBoxKalibracja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelDataRozp;
        private System.Windows.Forms.NumericUpDown NumericUCPnaFP;
        private System.Windows.Forms.GroupBox GroupBoxCOCOMOII;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxD;
        private System.Windows.Forms.TextBox TextBoxC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}