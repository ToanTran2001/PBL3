
namespace PBL3
{
    partial class ListP
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
            this.label1 = new System.Windows.Forms.Label();
            this.combKhuP = new System.Windows.Forms.ComboBox();
            this.dataViewP = new System.Windows.Forms.DataGridView();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.butTim = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.butCT = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.combSortP = new System.Windows.Forms.ComboBox();
            this.butSort = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHU :";
            // 
            // combKhuP
            // 
            this.combKhuP.FormattingEnabled = true;
            this.combKhuP.Location = new System.Drawing.Point(122, 27);
            this.combKhuP.Name = "combKhuP";
            this.combKhuP.Size = new System.Drawing.Size(121, 24);
            this.combKhuP.TabIndex = 1;
            // 
            // dataViewP
            // 
            this.dataViewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewP.Location = new System.Drawing.Point(35, 85);
            this.dataViewP.Name = "dataViewP";
            this.dataViewP.RowHeadersWidth = 51;
            this.dataViewP.RowTemplate.Height = 24;
            this.dataViewP.Size = new System.Drawing.Size(731, 287);
            this.dataViewP.TabIndex = 2;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(504, 27);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(134, 22);
            this.txtTim.TabIndex = 3;
            // 
            // butTim
            // 
            this.butTim.Location = new System.Drawing.Point(644, 27);
            this.butTim.Name = "butTim";
            this.butTim.Size = new System.Drawing.Size(75, 23);
            this.butTim.TabIndex = 4;
            this.butTim.Text = "Tìm";
            this.butTim.UseVisualStyleBackColor = true;
            // 
            // butShow
            // 
            this.butShow.Location = new System.Drawing.Point(93, 394);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(75, 23);
            this.butShow.TabIndex = 5;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = true;
            // 
            // butCT
            // 
            this.butCT.Location = new System.Drawing.Point(202, 394);
            this.butCT.Name = "butCT";
            this.butCT.Size = new System.Drawing.Size(75, 23);
            this.butCT.TabIndex = 6;
            this.butCT.Text = "Chi tiết";
            this.butCT.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(713, 415);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // combSortP
            // 
            this.combSortP.FormattingEnabled = true;
            this.combSortP.Location = new System.Drawing.Point(495, 394);
            this.combSortP.Name = "combSortP";
            this.combSortP.Size = new System.Drawing.Size(121, 24);
            this.combSortP.TabIndex = 8;
            // 
            // butSort
            // 
            this.butSort.Location = new System.Drawing.Point(414, 394);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(75, 23);
            this.butSort.TabIndex = 9;
            this.butSort.Text = "Sắp xếp";
            this.butSort.UseVisualStyleBackColor = true;
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(305, 394);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 23);
            this.butXoa.TabIndex = 10;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            // 
            // ListP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butSort);
            this.Controls.Add(this.combSortP);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butCT);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.dataViewP);
            this.Controls.Add(this.combKhuP);
            this.Controls.Add(this.label1);
            this.Name = "ListP";
            this.Text = "ListP";
            ((System.ComponentModel.ISupportInitialize)(this.dataViewP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combKhuP;
        private System.Windows.Forms.DataGridView dataViewP;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button butTim;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butCT;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.ComboBox combSortP;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.Button butXoa;
    }
}