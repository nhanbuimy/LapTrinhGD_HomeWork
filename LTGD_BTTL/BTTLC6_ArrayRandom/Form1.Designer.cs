
namespace BTTLC6_ArrayRandom
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSopt = new System.Windows.Forms.TextBox();
            this.btThongke = new System.Windows.Forms.Button();
            this.lbChan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTbCong = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbSonguyento = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbtaoMang = new System.Windows.Forms.Label();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phần tử:";
            // 
            // txtSopt
            // 
            this.txtSopt.Location = new System.Drawing.Point(179, 26);
            this.txtSopt.Name = "txtSopt";
            this.txtSopt.Size = new System.Drawing.Size(159, 30);
            this.txtSopt.TabIndex = 0;
            // 
            // btThongke
            // 
            this.btThongke.Location = new System.Drawing.Point(389, 22);
            this.btThongke.Name = "btThongke";
            this.btThongke.Size = new System.Drawing.Size(129, 39);
            this.btThongke.TabIndex = 1;
            this.btThongke.Text = "Thống kê";
            this.btThongke.UseVisualStyleBackColor = true;
            this.btThongke.Click += new System.EventHandler(this.btThongke_Click);
            // 
            // lbChan
            // 
            this.lbChan.BackColor = System.Drawing.Color.Plum;
            this.lbChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChan.Location = new System.Drawing.Point(242, 178);
            this.lbChan.Name = "lbChan";
            this.lbChan.Size = new System.Drawing.Size(456, 39);
            this.lbChan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng các phần tử chẳn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng các phần tử lẻ:";
            // 
            // lbLe
            // 
            this.lbLe.BackColor = System.Drawing.Color.Plum;
            this.lbLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLe.Location = new System.Drawing.Point(242, 275);
            this.lbLe.Name = "lbLe";
            this.lbLe.Size = new System.Drawing.Size(456, 39);
            this.lbLe.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 59);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trung bình cộng các phần tử trong mảng:";
            // 
            // lbTbCong
            // 
            this.lbTbCong.BackColor = System.Drawing.Color.Plum;
            this.lbTbCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTbCong.Location = new System.Drawing.Point(242, 363);
            this.lbTbCong.Name = "lbTbCong";
            this.lbTbCong.Size = new System.Drawing.Size(456, 39);
            this.lbTbCong.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số các số nguyên tố:";
            // 
            // lbSonguyento
            // 
            this.lbSonguyento.BackColor = System.Drawing.Color.Plum;
            this.lbSonguyento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSonguyento.Location = new System.Drawing.Point(242, 453);
            this.lbSonguyento.Name = "lbSonguyento";
            this.lbSonguyento.Size = new System.Drawing.Size(456, 39);
            this.lbSonguyento.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mảng ban đầu:";
            // 
            // lbtaoMang
            // 
            this.lbtaoMang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbtaoMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaoMang.Location = new System.Drawing.Point(242, 102);
            this.lbtaoMang.Name = "lbtaoMang";
            this.lbtaoMang.Size = new System.Drawing.Size(456, 39);
            this.lbtaoMang.TabIndex = 3;
            // 
            // btLamMoi
            // 
            this.btLamMoi.Location = new System.Drawing.Point(569, 22);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(129, 39);
            this.btLamMoi.TabIndex = 2;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 518);
            this.Controls.Add(this.lbSonguyento);
            this.Controls.Add(this.lbTbCong);
            this.Controls.Add(this.lbLe);
            this.Controls.Add(this.lbtaoMang);
            this.Controls.Add(this.lbChan);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btThongke);
            this.Controls.Add(this.txtSopt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình tạo ngẫu nhiên các số nguyên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSopt;
        private System.Windows.Forms.Button btThongke;
        private System.Windows.Forms.Label lbChan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTbCong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSonguyento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbtaoMang;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Timer timer1;
    }
}

