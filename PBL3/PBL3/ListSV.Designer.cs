
namespace PBL3
{
    partial class ListSV
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
            this.dataViewSV = new System.Windows.Forms.DataGridView();
            this.butTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.combKhuSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butShow = new System.Windows.Forms.Button();
            this.butCT = new System.Windows.Forms.Button();
            this.butSort = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.combSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewSV
            // 
            this.dataViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewSV.Location = new System.Drawing.Point(34, 72);
            this.dataViewSV.Name = "dataViewSV";
            this.dataViewSV.RowHeadersWidth = 51;
            this.dataViewSV.RowTemplate.Height = 24;
            this.dataViewSV.Size = new System.Drawing.Size(735, 296);
            this.dataViewSV.TabIndex = 0;
            // 
            // butTim
            // 
            this.butTim.Location = new System.Drawing.Point(669, 21);
            this.butTim.Name = "butTim";
            this.butTim.Size = new System.Drawing.Size(75, 23);
            this.butTim.TabIndex = 1;
            this.butTim.Text = "Tìm";
            this.butTim.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(537, 22);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(126, 22);
            this.txtTim.TabIndex = 3;
            // 
            // combKhuSV
            // 
            this.combKhuSV.FormattingEnabled = true;
            this.combKhuSV.Location = new System.Drawing.Point(116, 23);
            this.combKhuSV.Name = "combKhuSV";
            this.combKhuSV.Size = new System.Drawing.Size(121, 24);
            this.combKhuSV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "KHU :";
            // 
            // butShow
            // 
            this.butShow.Location = new System.Drawing.Point(86, 391);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(75, 23);
            this.butShow.TabIndex = 6;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = true;
            // 
            // butCT
            // 
            this.butCT.Location = new System.Drawing.Point(190, 391);
            this.butCT.Name = "butCT";
            this.butCT.Size = new System.Drawing.Size(75, 23);
            this.butCT.TabIndex = 7;
            this.butCT.Text = "Chi tiết";
            this.butCT.UseVisualStyleBackColor = true;
            // 
            // butSort
            // 
            this.butSort.Location = new System.Drawing.Point(405, 391);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(75, 23);
            this.butSort.TabIndex = 8;
            this.butSort.Text = "Sắp xếp";
            this.butSort.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(713, 415);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 9;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // combSort
            // 
            this.combSort.FormattingEnabled = true;
            this.combSort.Location = new System.Drawing.Point(486, 391);
            this.combSort.Name = "combSort";
            this.combSort.Size = new System.Drawing.Size(121, 24);
            this.combSort.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phòng :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(292, 391);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 23);
            this.butXoa.TabIndex = 13;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            // 
            // ListSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combSort);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSort);
            this.Controls.Add(this.butCT);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combKhuSV);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.butTim);
            this.Controls.Add(this.dataViewSV);
            this.Name = "ListSV";
            this.Text = "ListSV";
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewSV;
        private System.Windows.Forms.Button butTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox combKhuSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butCT;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.ComboBox combSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butXoa;
    }
}