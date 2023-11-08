
namespace BaiTapLamLai
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacPhepTinhDonGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.giupbehoctoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formProjectToolStripMenuItem
            // 
            this.formProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cacPhepTinhDonGianToolStripMenuItem,
            this.randomNumberToolStripMenuItem,
            this.giupbehoctoanToolStripMenuItem});
            this.formProjectToolStripMenuItem.Name = "formProjectToolStripMenuItem";
            this.formProjectToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.formProjectToolStripMenuItem.Text = "Form Project";
            // 
            // cacPhepTinhDonGianToolStripMenuItem
            // 
            this.cacPhepTinhDonGianToolStripMenuItem.Name = "cacPhepTinhDonGianToolStripMenuItem";
            this.cacPhepTinhDonGianToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.cacPhepTinhDonGianToolStripMenuItem.Text = "CacPhepTinhDonGian";
            this.cacPhepTinhDonGianToolStripMenuItem.Click += new System.EventHandler(this.cacPhepTinhDonGianToolStripMenuItem_Click);
            // 
            // randomNumberToolStripMenuItem
            // 
            this.randomNumberToolStripMenuItem.Name = "randomNumberToolStripMenuItem";
            this.randomNumberToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.randomNumberToolStripMenuItem.Text = "RandomNumber";
            this.randomNumberToolStripMenuItem.Click += new System.EventHandler(this.randomNumberToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhấn chọn form để mở";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giupbehoctoanToolStripMenuItem
            // 
            this.giupbehoctoanToolStripMenuItem.Name = "giupbehoctoanToolStripMenuItem";
            this.giupbehoctoanToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.giupbehoctoanToolStripMenuItem.Text = "Giupbehoctoan";
            this.giupbehoctoanToolStripMenuItem.Click += new System.EventHandler(this.giupbehoctoanToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Các bài tập trên lớp làm lại";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacPhepTinhDonGianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomNumberToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giupbehoctoanToolStripMenuItem;
    }
}

