
namespace BTTLC4_Combolistbox
{
    partial class Form1
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.cbChonmau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btPhai = new System.Windows.Forms.Button();
            this.btTrai = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btClearAll = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một chuỗi:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(25, 49);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(243, 30);
            this.txtNhap.TabIndex = 1;
            // 
            // btInsert
            // 
            this.btInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btInsert.Location = new System.Drawing.Point(25, 95);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(88, 34);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // cbChonmau
            // 
            this.cbChonmau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonmau.FormattingEnabled = true;
            this.cbChonmau.Location = new System.Drawing.Point(477, 49);
            this.cbChonmau.Name = "cbChonmau";
            this.cbChonmau.Size = new System.Drawing.Size(243, 33);
            this.cbChonmau.TabIndex = 3;
            this.cbChonmau.SelectedIndexChanged += new System.EventHandler(this.cbChonmau_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(472, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn màu:";
            // 
            // btPhai
            // 
            this.btPhai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btPhai.Location = new System.Drawing.Point(310, 202);
            this.btPhai.Name = "btPhai";
            this.btPhai.Size = new System.Drawing.Size(129, 44);
            this.btPhai.TabIndex = 2;
            this.btPhai.Text = "==>";
            this.btPhai.UseVisualStyleBackColor = true;
            this.btPhai.Click += new System.EventHandler(this.btPhai_Click);
            // 
            // btTrai
            // 
            this.btTrai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btTrai.Location = new System.Drawing.Point(310, 262);
            this.btTrai.Name = "btTrai";
            this.btTrai.Size = new System.Drawing.Size(129, 44);
            this.btTrai.TabIndex = 2;
            this.btTrai.Text = "<==";
            this.btTrai.UseVisualStyleBackColor = true;
            this.btTrai.Click += new System.EventHandler(this.btTrai_Click);
            // 
            // btRemove
            // 
            this.btRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btRemove.Location = new System.Drawing.Point(310, 322);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(129, 44);
            this.btRemove.TabIndex = 2;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btClearAll
            // 
            this.btClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btClearAll.Location = new System.Drawing.Point(310, 382);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(129, 44);
            this.btClearAll.TabIndex = 2;
            this.btClearAll.Text = "ClearAll";
            this.btClearAll.UseVisualStyleBackColor = true;
            this.btClearAll.Click += new System.EventHandler(this.btClearAll_Click);
            // 
            // btExit
            // 
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btExit.Location = new System.Drawing.Point(310, 442);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(129, 44);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(476, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 429);
            this.listBox1.TabIndex = 5;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(22, 140);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox.Size = new System.Drawing.Size(243, 429);
            this.listBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 588);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbChonmau);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btClearAll);
            this.Controls.Add(this.btTrai);
            this.Controls.Add(this.btPhai);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.ComboBox cbChonmau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPhai;
        private System.Windows.Forms.Button btTrai;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btClearAll;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox;
    }
}

