﻿namespace Aplikacja
{
    partial class OknoCzynnikiSkali
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
            this.ButtonOk = new System.Windows.Forms.Button();
            this.GroupBoxCzynSkali = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxCzynnSkTyp = new System.Windows.Forms.ComboBox();
            this.ComboBoxCzynnSkElast = new System.Windows.Forms.ComboBox();
            this.ComboBoxCzynnSkRyzyko = new System.Windows.Forms.ComboBox();
            this.ComboBoxCzynnSkZesp = new System.Windows.Forms.ComboBox();
            this.ComboBoxCzynnSkDojrz = new System.Windows.Forms.ComboBox();
            this.ButtonAnuluj = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBoxCzynSkali.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOk.Location = new System.Drawing.Point(206, 400);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(104, 27);
            this.ButtonOk.TabIndex = 3;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // GroupBoxCzynSkali
            // 
            this.GroupBoxCzynSkali.Controls.Add(this.tableLayoutPanel1);
            this.GroupBoxCzynSkali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxCzynSkali.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxCzynSkali.Name = "GroupBoxCzynSkali";
            this.GroupBoxCzynSkali.Size = new System.Drawing.Size(659, 365);
            this.GroupBoxCzynSkali.TabIndex = 4;
            this.GroupBoxCzynSkali.TabStop = false;
            this.GroupBoxCzynSkali.Text = "Czynniki skali";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxCzynnSkTyp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxCzynnSkElast, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxCzynnSkRyzyko, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxCzynnSkZesp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxCzynnSkDojrz, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 324);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 64);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elastyczność wytwarzania oprogramowania";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 64);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zarządzanie ryzykiem";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 64);
            this.label4.TabIndex = 9;
            this.label4.Text = "Spójność zespołu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 68);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dojrzałość procesu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "Typowość projektu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxCzynnSkTyp
            // 
            this.ComboBoxCzynnSkTyp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCzynnSkTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCzynnSkTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxCzynnSkTyp.FormattingEnabled = true;
            this.ComboBoxCzynnSkTyp.Items.AddRange(new object[] {
            "Bardzo niski",
            "Niski",
            "Nominalny",
            "Wysoki",
            "Bardzo wysoki",
            "Ekstra wysoki"});
            this.ComboBoxCzynnSkTyp.Location = new System.Drawing.Point(139, 17);
            this.ComboBoxCzynnSkTyp.Margin = new System.Windows.Forms.Padding(3, 17, 3, 3);
            this.ComboBoxCzynnSkTyp.Name = "ComboBoxCzynnSkTyp";
            this.ComboBoxCzynnSkTyp.Size = new System.Drawing.Size(123, 24);
            this.ComboBoxCzynnSkTyp.TabIndex = 0;
            this.ComboBoxCzynnSkTyp.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCzynnSkTyp_SelectedIndexChanged);
            // 
            // ComboBoxCzynnSkElast
            // 
            this.ComboBoxCzynnSkElast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCzynnSkElast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCzynnSkElast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxCzynnSkElast.FormattingEnabled = true;
            this.ComboBoxCzynnSkElast.Items.AddRange(new object[] {
            "Bardzo niski",
            "Niski",
            "Nominalny",
            "Wysoki",
            "Bardzo wysoki",
            "Ekstra wysoki"});
            this.ComboBoxCzynnSkElast.Location = new System.Drawing.Point(139, 78);
            this.ComboBoxCzynnSkElast.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.ComboBoxCzynnSkElast.Name = "ComboBoxCzynnSkElast";
            this.ComboBoxCzynnSkElast.Size = new System.Drawing.Size(123, 24);
            this.ComboBoxCzynnSkElast.TabIndex = 11;
            this.ComboBoxCzynnSkElast.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCzynnSkElast_SelectedIndexChanged);
            // 
            // ComboBoxCzynnSkRyzyko
            // 
            this.ComboBoxCzynnSkRyzyko.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCzynnSkRyzyko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCzynnSkRyzyko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxCzynnSkRyzyko.FormattingEnabled = true;
            this.ComboBoxCzynnSkRyzyko.Items.AddRange(new object[] {
            "Bardzo niski",
            "Niski",
            "Nominalny",
            "Wysoki",
            "Bardzo wysoki",
            "Ekstra wysoki"});
            this.ComboBoxCzynnSkRyzyko.Location = new System.Drawing.Point(139, 145);
            this.ComboBoxCzynnSkRyzyko.Margin = new System.Windows.Forms.Padding(3, 17, 3, 3);
            this.ComboBoxCzynnSkRyzyko.Name = "ComboBoxCzynnSkRyzyko";
            this.ComboBoxCzynnSkRyzyko.Size = new System.Drawing.Size(123, 24);
            this.ComboBoxCzynnSkRyzyko.TabIndex = 12;
            this.ComboBoxCzynnSkRyzyko.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCzynnSkRyzyko_SelectedIndexChanged);
            // 
            // ComboBoxCzynnSkZesp
            // 
            this.ComboBoxCzynnSkZesp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCzynnSkZesp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCzynnSkZesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxCzynnSkZesp.FormattingEnabled = true;
            this.ComboBoxCzynnSkZesp.Items.AddRange(new object[] {
            "Bardzo niski",
            "Niski",
            "Nominalny",
            "Wysoki",
            "Bardzo wysoki",
            "Ekstra wysoki"});
            this.ComboBoxCzynnSkZesp.Location = new System.Drawing.Point(139, 209);
            this.ComboBoxCzynnSkZesp.Margin = new System.Windows.Forms.Padding(3, 17, 3, 3);
            this.ComboBoxCzynnSkZesp.Name = "ComboBoxCzynnSkZesp";
            this.ComboBoxCzynnSkZesp.Size = new System.Drawing.Size(123, 24);
            this.ComboBoxCzynnSkZesp.TabIndex = 13;
            this.ComboBoxCzynnSkZesp.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCzynnSkZesp_SelectedIndexChanged);
            // 
            // ComboBoxCzynnSkDojrz
            // 
            this.ComboBoxCzynnSkDojrz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCzynnSkDojrz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCzynnSkDojrz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxCzynnSkDojrz.FormattingEnabled = true;
            this.ComboBoxCzynnSkDojrz.Items.AddRange(new object[] {
            "Bardzo niski",
            "Niski",
            "Nominalny",
            "Wysoki",
            "Bardzo wysoki",
            "Ekstra wysoki"});
            this.ComboBoxCzynnSkDojrz.Location = new System.Drawing.Point(139, 274);
            this.ComboBoxCzynnSkDojrz.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.ComboBoxCzynnSkDojrz.Name = "ComboBoxCzynnSkDojrz";
            this.ComboBoxCzynnSkDojrz.Size = new System.Drawing.Size(123, 24);
            this.ComboBoxCzynnSkDojrz.TabIndex = 14;
            this.ComboBoxCzynnSkDojrz.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCzynnSkDojrz_SelectedIndexChanged);
            // 
            // ButtonAnuluj
            // 
            this.ButtonAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAnuluj.Location = new System.Drawing.Point(366, 400);
            this.ButtonAnuluj.Name = "ButtonAnuluj";
            this.ButtonAnuluj.Size = new System.Drawing.Size(104, 27);
            this.ButtonAnuluj.TabIndex = 5;
            this.ButtonAnuluj.Text = "Anuluj";
            this.ButtonAnuluj.UseVisualStyleBackColor = true;
            // 
            // OknoCzynnikiSkali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 467);
            this.Controls.Add(this.ButtonAnuluj);
            this.Controls.Add(this.GroupBoxCzynSkali);
            this.Controls.Add(this.ButtonOk);
            this.Name = "OknoCzynnikiSkali";
            this.Text = "Czynniki skali";
            this.GroupBoxCzynSkali.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.GroupBox GroupBoxCzynSkali;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonAnuluj;
        private System.Windows.Forms.ComboBox ComboBoxCzynnSkTyp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxCzynnSkElast;
        private System.Windows.Forms.ComboBox ComboBoxCzynnSkRyzyko;
        private System.Windows.Forms.ComboBox ComboBoxCzynnSkZesp;
        private System.Windows.Forms.ComboBox ComboBoxCzynnSkDojrz;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}