﻿
namespace Phan_mem_quan_ly_ban_thuoc.Forms_Update
{
    partial class frmUp_nhomthuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUp_nhomthuoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblNhomthuocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tHUOCDataSet = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSet();
            this.tblNhanvienTableAdapter = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSetTableAdapters.tblNhanvienTableAdapter();
            this.tblNhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MANHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNhomthuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tblThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.tblThuocTableAdapter = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSetTableAdapters.tblThuocTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblNhomthuocTableAdapter = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSetTableAdapters.tblNhomthuocTableAdapter();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhomthuocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhomthuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblNhomthuocBindingSource1
            // 
            this.tblNhomthuocBindingSource1.DataMember = "tblNhomthuoc";
            this.tblNhomthuocBindingSource1.DataSource = this.tHUOCDataSet;
            // 
            // tHUOCDataSet
            // 
            this.tHUOCDataSet.DataSetName = "THUOCDataSet";
            this.tHUOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNhanvienTableAdapter
            // 
            this.tblNhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // tblNhanvienBindingSource
            // 
            this.tblNhanvienBindingSource.DataMember = "tblNhanvien";
            this.tblNhanvienBindingSource.DataSource = this.tHUOCDataSet;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 142;
            this.pictureBox2.TabStop = false;
            // 
            // grdData
            // 
            this.grdData.AutoGenerateColumns = false;
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdData.ColumnHeadersHeight = 30;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANHOM,
            this.TENNHOM,
            this.GHICHU});
            this.grdData.DataSource = this.tblNhomthuocBindingSource;
            this.grdData.Location = new System.Drawing.Point(997, 172);
            this.grdData.Margin = new System.Windows.Forms.Padding(6);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.Size = new System.Drawing.Size(484, 195);
            this.grdData.TabIndex = 138;
            // 
            // MANHOM
            // 
            this.MANHOM.DataPropertyName = "MANHOM";
            this.MANHOM.HeaderText = "MANHOM";
            this.MANHOM.MinimumWidth = 6;
            this.MANHOM.Name = "MANHOM";
            this.MANHOM.Width = 125;
            // 
            // TENNHOM
            // 
            this.TENNHOM.DataPropertyName = "TENNHOM";
            this.TENNHOM.HeaderText = "TENNHOM";
            this.TENNHOM.MinimumWidth = 6;
            this.TENNHOM.Name = "TENNHOM";
            this.TENNHOM.Width = 125;
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "GHICHU";
            this.GHICHU.MinimumWidth = 6;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Width = 125;
            // 
            // tblNhomthuocBindingSource
            // 
            this.tblNhomthuocBindingSource.DataMember = "tblNhomthuoc";
            this.tblNhomthuocBindingSource.DataSource = this.tHUOCDataSet;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.pictureBox5.Location = new System.Drawing.Point(-1, 660);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(991, 15);
            this.pictureBox5.TabIndex = 141;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.pictureBox3.Location = new System.Drawing.Point(-1, 91);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 604);
            this.pictureBox3.TabIndex = 139;
            this.pictureBox3.TabStop = false;
            // 
            // tblThuocBindingSource
            // 
            this.tblThuocBindingSource.DataMember = "tblThuoc";
            this.tblThuocBindingSource.DataSource = this.tHUOCDataSet;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.pictureBox4.Location = new System.Drawing.Point(972, 5);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 690);
            this.pictureBox4.TabIndex = 140;
            this.pictureBox4.TabStop = false;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.Location = new System.Drawing.Point(318, 286);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(560, 165);
            this.txtGhichu.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 137;
            this.label5.Text = "Ghi chú :";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(318, 212);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(347, 35);
            this.txtTen.TabIndex = 1;
            // 
            // tblThuocTableAdapter
            // 
            this.tblThuocTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 136;
            this.label3.Text = "Tên nhóm thuốc :";
            // 
            // txtMa
            // 
            this.txtMa.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMa.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(318, 141);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(347, 35);
            this.txtMa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 135;
            this.label2.Text = "Mã nhóm thuốc :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.label1.Font = new System.Drawing.Font("Nunito Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(107, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 55);
            this.label1.TabIndex = 134;
            this.label1.Text = "Thông tin nhóm thuốc";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 102);
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // tblNhomthuocTableAdapter
            // 
            this.tblNhomthuocTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(640, 520);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(208, 86);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Trở về";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(156, 520);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(208, 86);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnThemlai_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(399, 520);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 86);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(288, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 29);
            this.label8.TabIndex = 143;
            this.label8.Text = "*";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(318, 141);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 35);
            this.textBox1.TabIndex = 144;
            // 
            // frmUp_nhomthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 675);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUp_nhomthuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUp_nhomthuoc";
            this.Load += new System.EventHandler(this.frmUp_nhomthuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblNhomthuocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhomthuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblNhomthuocBindingSource1;
        private THUOCDataSet tHUOCDataSet;
        private THUOCDataSetTableAdapters.tblNhanvienTableAdapter tblNhanvienTableAdapter;
        private System.Windows.Forms.BindingSource tblNhanvienBindingSource;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANHOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNHOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.BindingSource tblNhomthuocBindingSource;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.BindingSource tblThuocBindingSource;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTen;
        private THUOCDataSetTableAdapters.tblThuocTableAdapter tblThuocTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private THUOCDataSetTableAdapters.tblNhomthuocTableAdapter tblNhomthuocTableAdapter;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}