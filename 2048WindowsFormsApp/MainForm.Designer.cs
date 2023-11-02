namespace _2048WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.score_MainForm_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьЗановаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.bestScore_MainForm_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счет:";
            // 
            // score_MainForm_label
            // 
            this.score_MainForm_label.AutoSize = true;
            this.score_MainForm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_MainForm_label.Location = new System.Drawing.Point(153, 63);
            this.score_MainForm_label.Name = "score_MainForm_label";
            this.score_MainForm_label.Size = new System.Drawing.Size(15, 16);
            this.score_MainForm_label.TabIndex = 1;
            this.score_MainForm_label.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.результатыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаToolStripMenuItem,
            this.начатьЗановаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.правилаToolStripMenuItem_Click);
            // 
            // начатьЗановаToolStripMenuItem
            // 
            this.начатьЗановаToolStripMenuItem.Name = "начатьЗановаToolStripMenuItem";
            this.начатьЗановаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.начатьЗановаToolStripMenuItem.Text = "Начать";
            this.начатьЗановаToolStripMenuItem.Click += new System.EventHandler(this.начатьЗановаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // результатыToolStripMenuItem
            // 
            this.результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            this.результатыToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.результатыToolStripMenuItem.Text = "Результаты";
            this.результатыToolStripMenuItem.Click += new System.EventHandler(this.результатыToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Лучший результат:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bestScore_MainForm_label
            // 
            this.bestScore_MainForm_label.AutoSize = true;
            this.bestScore_MainForm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScore_MainForm_label.Location = new System.Drawing.Point(153, 37);
            this.bestScore_MainForm_label.Name = "bestScore_MainForm_label";
            this.bestScore_MainForm_label.Size = new System.Drawing.Size(15, 16);
            this.bestScore_MainForm_label.TabIndex = 1;
            this.bestScore_MainForm_label.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 468);
            this.Controls.Add(this.bestScore_MainForm_label);
            this.Controls.Add(this.score_MainForm_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score_MainForm_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьЗановаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bestScore_MainForm_label;
        private System.Windows.Forms.ToolStripMenuItem результатыToolStripMenuItem;
    }
}

