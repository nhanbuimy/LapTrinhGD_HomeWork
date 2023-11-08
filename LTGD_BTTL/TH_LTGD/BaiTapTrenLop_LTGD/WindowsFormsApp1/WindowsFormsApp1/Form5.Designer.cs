
namespace WindowsFormsApp1
{
    partial class Form5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbThanhngang = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapspt = new System.Windows.Forms.TextBox();
            this.lbtaoMang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSonguyento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btPlay = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbThanhngang
            // 
            this.lbThanhngang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbThanhngang.Location = new System.Drawing.Point(8, 144);
            this.lbThanhngang.Name = "lbThanhngang";
            this.lbThanhngang.Size = new System.Drawing.Size(100, 76);
            this.lbThanhngang.TabIndex = 1;
            this.lbThanhngang.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbThanhngang_MouseDown);
            this.lbThanhngang.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbThanhngang_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "n = ";
            // 
            // txtNhapspt
            // 
            this.txtNhapspt.Location = new System.Drawing.Point(407, 55);
            this.txtNhapspt.Name = "txtNhapspt";
            this.txtNhapspt.Size = new System.Drawing.Size(100, 26);
            this.txtNhapspt.TabIndex = 3;
            // 
            // lbtaoMang
            // 
            this.lbtaoMang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbtaoMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaoMang.Location = new System.Drawing.Point(292, 116);
            this.lbtaoMang.Name = "lbtaoMang";
            this.lbtaoMang.Size = new System.Drawing.Size(496, 41);
            this.lbtaoMang.TabIndex = 4;
            this.lbtaoMang.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "So nguyen to: ";
            // 
            // lbSonguyento
            // 
            this.lbSonguyento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbSonguyento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSonguyento.Location = new System.Drawing.Point(292, 266);
            this.lbSonguyento.Name = "lbSonguyento";
            this.lbSonguyento.Size = new System.Drawing.Size(496, 76);
            this.lbSonguyento.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mang ban dau:";
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(592, 26);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(150, 55);
            this.btPlay.TabIndex = 6;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(227, 367);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(150, 55);
            this.btReset.TabIndex = 6;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSonguyento);
            this.Controls.Add(this.lbtaoMang);
            this.Controls.Add(this.txtNhapspt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbThanhngang);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbThanhngang;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapspt;
        private System.Windows.Forms.Label lbtaoMang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSonguyento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btReset;
    }
}