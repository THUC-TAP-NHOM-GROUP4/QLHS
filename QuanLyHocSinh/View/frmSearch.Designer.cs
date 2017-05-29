namespace QuanLyHocSinh.View
{
    partial class frmSearch
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
            this.dgvdstimkiem = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.TXTma = new System.Windows.Forms.TextBox();
            this.lbma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdstimkiem
            // 
            this.dgvdstimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdstimkiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdstimkiem.Location = new System.Drawing.Point(0, 191);
            this.dgvdstimkiem.Name = "dgvdstimkiem";
            this.dgvdstimkiem.Size = new System.Drawing.Size(507, 150);
            this.dgvdstimkiem.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách ";
            // 
            // cbbSearch
            // 
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(141, 39);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(160, 21);
            this.cbbSearch.TabIndex = 3;
            this.cbbSearch.Text = "Chọn từ khóa tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(32, 36);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 4;
            this.btntimkiem.Text = "Search";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // TXTma
            // 
            this.TXTma.Location = new System.Drawing.Point(141, 76);
            this.TXTma.Name = "TXTma";
            this.TXTma.Size = new System.Drawing.Size(165, 20);
            this.TXTma.TabIndex = 5;
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Location = new System.Drawing.Point(41, 79);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(78, 13);
            this.lbma.TabIndex = 6;
            this.lbma.Text = "Nhập từ khóa :";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 341);
            this.Controls.Add(this.lbma);
            this.Controls.Add(this.TXTma);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.cbbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvdstimkiem);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdstimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox TXTma;
        private System.Windows.Forms.Label lbma;
    }
}