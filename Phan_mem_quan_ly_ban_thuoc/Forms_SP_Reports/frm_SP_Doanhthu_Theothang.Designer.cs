﻿
namespace Phan_mem_quan_ly_ban_thuoc.Forms_SP_Reports
{
    partial class frm_SP_Doanhthu_Theothang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SP_Doanhthu_Theothang));
            this.txtNguoidung = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Baocao = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNguoidung
            // 
            this.txtNguoidung.Location = new System.Drawing.Point(759, 120);
            this.txtNguoidung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNguoidung.Name = "txtNguoidung";
            this.txtNguoidung.Size = new System.Drawing.Size(275, 26);
            this.txtNguoidung.TabIndex = 12;
            this.txtNguoidung.Visible = false;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.button1.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(176, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Baocao
            // 
            this.btn_Baocao.AccessibleDescription = "";
            this.btn_Baocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btn_Baocao.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baocao.ForeColor = System.Drawing.Color.White;
            this.btn_Baocao.Location = new System.Drawing.Point(176, 140);
            this.btn_Baocao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Baocao.Name = "btn_Baocao";
            this.btn_Baocao.Size = new System.Drawing.Size(333, 62);
            this.btn_Baocao.TabIndex = 0;
            this.btn_Baocao.Text = "Lập báo cáo";
            this.btn_Baocao.UseVisualStyleBackColor = false;
            this.btn_Baocao.Click += new System.EventHandler(this.btn_Baocao_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(759, 208);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(275, 26);
            this.txtTen.TabIndex = 13;
            this.txtTen.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 38);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bạn có muốn lập báo cáo không ?";
            // 
            // frm_SP_Doanhthu_Theothang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(705, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtNguoidung);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Baocao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_SP_Doanhthu_Theothang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SP_Doanhthu_Theothang";
            this.Load += new System.EventHandler(this.frm_SP_Doanhthu_Theothang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNguoidung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Baocao;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
    }
}