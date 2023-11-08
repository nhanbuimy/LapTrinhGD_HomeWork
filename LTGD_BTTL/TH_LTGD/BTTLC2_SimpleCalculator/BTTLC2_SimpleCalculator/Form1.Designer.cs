
namespace BTTLC2_SimpleCalculator
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
            this.lbPheptinh = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btXoalui = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btBang = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPheptinh
            // 
            this.lbPheptinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPheptinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPheptinh.Location = new System.Drawing.Point(52, 117);
            this.lbPheptinh.Name = "lbPheptinh";
            this.lbPheptinh.Size = new System.Drawing.Size(366, 64);
            this.lbPheptinh.TabIndex = 1;
            this.lbPheptinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDel
            // 
            this.btDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btDel.Location = new System.Drawing.Point(55, 227);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(156, 52);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "DEL";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btXoalui
            // 
            this.btXoalui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btXoalui.Location = new System.Drawing.Point(260, 227);
            this.btXoalui.Name = "btXoalui";
            this.btXoalui.Size = new System.Drawing.Size(156, 52);
            this.btXoalui.TabIndex = 2;
            this.btXoalui.Text = "R";
            this.btXoalui.UseVisualStyleBackColor = true;
            this.btXoalui.Click += new System.EventHandler(this.btXoalui_Click);
            // 
            // bt0
            // 
            this.bt0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt0.Location = new System.Drawing.Point(56, 482);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(73, 45);
            this.bt0.TabIndex = 3;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btBang
            // 
            this.btBang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btBang.Location = new System.Drawing.Point(144, 482);
            this.btBang.Name = "btBang";
            this.btBang.Size = new System.Drawing.Size(160, 45);
            this.btBang.TabIndex = 3;
            this.btBang.Text = "=";
            this.btBang.UseVisualStyleBackColor = true;
            this.btBang.Click += new System.EventHandler(this.btBang_Click);
            // 
            // btCong
            // 
            this.btCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btCong.Location = new System.Drawing.Point(317, 480);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(97, 45);
            this.btCong.TabIndex = 3;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(56, 423);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 45);
            this.button6.TabIndex = 3;
            this.button6.Text = "1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.bt0_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(143, 423);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 45);
            this.button7.TabIndex = 3;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btTru
            // 
            this.btTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btTru.Location = new System.Drawing.Point(317, 423);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(97, 45);
            this.btTru.TabIndex = 3;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btCong_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button9.Location = new System.Drawing.Point(56, 366);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 45);
            this.button9.TabIndex = 3;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btNhan
            // 
            this.btNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btNhan.Location = new System.Drawing.Point(317, 366);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(97, 45);
            this.btNhan.TabIndex = 3;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btCong_Click);
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button12.Location = new System.Drawing.Point(56, 309);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 45);
            this.button12.TabIndex = 3;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btChia
            // 
            this.btChia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btChia.Location = new System.Drawing.Point(317, 309);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(97, 45);
            this.btChia.TabIndex = 3;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btCong_Click);
            // 
            // button15
            // 
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button15.Location = new System.Drawing.Point(230, 423);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 45);
            this.button15.TabIndex = 3;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.bt0_Click);
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button10.Location = new System.Drawing.Point(143, 366);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 45);
            this.button10.TabIndex = 3;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.bt0_Click);
            // 
            // button16
            // 
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button16.Location = new System.Drawing.Point(230, 366);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(73, 45);
            this.button16.TabIndex = 3;
            this.button16.Text = "6";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.bt0_Click);
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button13.Location = new System.Drawing.Point(143, 309);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 45);
            this.button13.TabIndex = 3;
            this.button13.Text = "8";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.bt0_Click);
            // 
            // button17
            // 
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button17.Location = new System.Drawing.Point(230, 309);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(73, 45);
            this.button17.TabIndex = 3;
            this.button17.Text = "9";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.bt0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(471, 557);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btBang);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btXoalui);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.lbPheptinh);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPheptinh;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btXoalui;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btBang;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button17;
    }
}

