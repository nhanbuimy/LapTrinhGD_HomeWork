
namespace SimplePaint
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawByMouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawByMouseToolStripMenuItem,
            this.drawTextToolStripMenuItem,
            this.drawImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // drawByMouseToolStripMenuItem
            // 
            this.drawByMouseToolStripMenuItem.Name = "drawByMouseToolStripMenuItem";
            this.drawByMouseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.drawByMouseToolStripMenuItem.Text = "Draw By Mouse";
            this.drawByMouseToolStripMenuItem.Click += new System.EventHandler(this.drawByMouseToolStripMenuItem_Click);
            // 
            // drawTextToolStripMenuItem
            // 
            this.drawTextToolStripMenuItem.Name = "drawTextToolStripMenuItem";
            this.drawTextToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.drawTextToolStripMenuItem.Text = "Draw Text";
            this.drawTextToolStripMenuItem.Click += new System.EventHandler(this.drawTextToolStripMenuItem_Click);
            // 
            // drawImageToolStripMenuItem
            // 
            this.drawImageToolStripMenuItem.Name = "drawImageToolStripMenuItem";
            this.drawImageToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.drawImageToolStripMenuItem.Text = "Draw Image";
            this.drawImageToolStripMenuItem.Click += new System.EventHandler(this.drawImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawByMouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

