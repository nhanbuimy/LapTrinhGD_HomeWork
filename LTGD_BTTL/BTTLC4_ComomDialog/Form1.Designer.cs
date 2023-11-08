
namespace BTTLC4_ComomDialog
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
            this.components = new System.ComponentModel.Container();
            this.btChon1 = new System.Windows.Forms.Button();
            this.btChonnhieu = new System.Windows.Forms.Button();
            this.btChonThuMuc = new System.Windows.Forms.Button();
            this.btChonMaunen = new System.Windows.Forms.Button();
            this.btChonMauChu = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerOpen = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btChon1
            // 
            this.btChon1.Location = new System.Drawing.Point(29, 36);
            this.btChon1.Name = "btChon1";
            this.btChon1.Size = new System.Drawing.Size(241, 49);
            this.btChon1.TabIndex = 0;
            this.btChon1.Text = "Chọn một tập tin";
            this.btChon1.UseVisualStyleBackColor = true;
            this.btChon1.Click += new System.EventHandler(this.btChon1_Click);
            // 
            // btChonnhieu
            // 
            this.btChonnhieu.Location = new System.Drawing.Point(29, 125);
            this.btChonnhieu.Name = "btChonnhieu";
            this.btChonnhieu.Size = new System.Drawing.Size(241, 49);
            this.btChonnhieu.TabIndex = 0;
            this.btChonnhieu.Text = "Chọn nhiều tập tin";
            this.btChonnhieu.UseVisualStyleBackColor = true;
            this.btChonnhieu.Click += new System.EventHandler(this.btChonnhieu_Click);
            // 
            // btChonThuMuc
            // 
            this.btChonThuMuc.Location = new System.Drawing.Point(29, 214);
            this.btChonThuMuc.Name = "btChonThuMuc";
            this.btChonThuMuc.Size = new System.Drawing.Size(241, 49);
            this.btChonThuMuc.TabIndex = 0;
            this.btChonThuMuc.Text = "Chọn thư mục";
            this.btChonThuMuc.UseVisualStyleBackColor = true;
            this.btChonThuMuc.Click += new System.EventHandler(this.btChonThuMuc_Click);
            // 
            // btChonMaunen
            // 
            this.btChonMaunen.Location = new System.Drawing.Point(29, 303);
            this.btChonMaunen.Name = "btChonMaunen";
            this.btChonMaunen.Size = new System.Drawing.Size(241, 49);
            this.btChonMaunen.TabIndex = 0;
            this.btChonMaunen.Text = "Chọn màu nền";
            this.btChonMaunen.UseVisualStyleBackColor = true;
            this.btChonMaunen.Click += new System.EventHandler(this.btChonMaunen_Click);
            // 
            // btChonMauChu
            // 
            this.btChonMauChu.Location = new System.Drawing.Point(29, 392);
            this.btChonMauChu.Name = "btChonMauChu";
            this.btChonMauChu.Size = new System.Drawing.Size(241, 49);
            this.btChonMauChu.TabIndex = 0;
            this.btChonMauChu.Text = "Chọn màu chữ";
            this.btChonMauChu.UseVisualStyleBackColor = true;
            this.btChonMauChu.Click += new System.EventHandler(this.btChonMauChu_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(29, 481);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(241, 49);
            this.button6.TabIndex = 0;
            this.button6.Text = "Chọn font";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(295, 481);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(241, 49);
            this.button7.TabIndex = 0;
            this.button7.Text = "Reset";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(597, 481);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(241, 49);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerOpen
            // 
            this.timerOpen.Enabled = true;
            this.timerOpen.Tick += new System.EventHandler(this.timerOpen_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(295, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(543, 426);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 567);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btChonMauChu);
            this.Controls.Add(this.btChonMaunen);
            this.Controls.Add(this.btChonThuMuc);
            this.Controls.Add(this.btChonnhieu);
            this.Controls.Add(this.btChon1);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Common Dialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChon1;
        private System.Windows.Forms.Button btChonnhieu;
        private System.Windows.Forms.Button btChonThuMuc;
        private System.Windows.Forms.Button btChonMaunen;
        private System.Windows.Forms.Button btChonMauChu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerOpen;
        private System.Windows.Forms.TextBox textBox1;
    }
}

