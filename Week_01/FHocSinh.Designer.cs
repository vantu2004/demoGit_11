﻿namespace Week_01
{
    partial class FHocSinh
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
            this.ucThongTin = new Week_01.UCThongTin();
            this.SuspendLayout();
            // 
            // ucThongTin
            // 
            this.ucThongTin.Location = new System.Drawing.Point(1, 0);
            this.ucThongTin.Name = "ucThongTin";
            this.ucThongTin.Size = new System.Drawing.Size(1122, 283);
            this.ucThongTin.TabIndex = 0;
            this.ucThongTin.Load += new System.EventHandler(this.ucThongTin_Load);
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 283);
            this.Controls.Add(this.ucThongTin);
            this.Name = "FHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn cmndDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private UCThongTin ucThongTin;
    }
}

