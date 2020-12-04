namespace Final
{
    partial class MainForm
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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Command_Box = new System.Windows.Forms.TextBox();
            this.txt_Execution_Box = new System.Windows.Forms.TextBox();
            this.Output_Box = new System.Windows.Forms.Panel();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.applicationGuideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(629, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.importToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // applicationGuideToolStripMenuItem
            // 
            this.applicationGuideToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.applicationGuideToolStripMenuItem.Name = "applicationGuideToolStripMenuItem";
            this.applicationGuideToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.applicationGuideToolStripMenuItem.Text = "Help";
            this.applicationGuideToolStripMenuItem.Click += new System.EventHandler(this.applicationGuideToolStripMenuItem_Click);
            // 
            // txt_Command_Box
            // 
            this.txt_Command_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Command_Box.Location = new System.Drawing.Point(28, 42);
            this.txt_Command_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Command_Box.MaximumSize = new System.Drawing.Size(80, 57);
            this.txt_Command_Box.MinimumSize = new System.Drawing.Size(507, 81);
            this.txt_Command_Box.Multiline = true;
            this.txt_Command_Box.Name = "txt_Command_Box";
            this.txt_Command_Box.Size = new System.Drawing.Size(507, 81);
            this.txt_Command_Box.TabIndex = 12;
            // 
            // txt_Execution_Box
            // 
            this.txt_Execution_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Execution_Box.Location = new System.Drawing.Point(28, 126);
            this.txt_Execution_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Execution_Box.Name = "txt_Execution_Box";
            this.txt_Execution_Box.Size = new System.Drawing.Size(144, 41);
            this.txt_Execution_Box.TabIndex = 3;
            this.txt_Execution_Box.TextChanged += new System.EventHandler(this.txt_Execution_Box_TextChanged);
            // 
            // Output_Box
            // 
            this.Output_Box.Location = new System.Drawing.Point(28, 169);
            this.Output_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Output_Box.Name = "Output_Box";
            this.Output_Box.Size = new System.Drawing.Size(569, 294);
            this.Output_Box.TabIndex = 6;
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 481);
            this.Controls.Add(this.Output_Box);
            this.Controls.Add(this.txt_Execution_Box);
            this.Controls.Add(this.txt_Command_Box);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationGuideToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Command_Box;
        private System.Windows.Forms.TextBox txt_Execution_Box;
        private System.Windows.Forms.Panel Output_Box;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

