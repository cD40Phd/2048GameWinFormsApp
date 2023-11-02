namespace _2048WindowsFormsApp
{
    partial class AskNameUserForm
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
            this.nameUser_AskNameUserForm_textBox = new System.Windows.Forms.TextBox();
            this.Ok_AskNameUserForm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Представтесь:";
            // 
            // nameUser_AskNameUserForm_textBox
            // 
            this.nameUser_AskNameUserForm_textBox.Location = new System.Drawing.Point(122, 18);
            this.nameUser_AskNameUserForm_textBox.Name = "nameUser_AskNameUserForm_textBox";
            this.nameUser_AskNameUserForm_textBox.Size = new System.Drawing.Size(267, 22);
            this.nameUser_AskNameUserForm_textBox.TabIndex = 1;
            this.nameUser_AskNameUserForm_textBox.Text = "Ваше имя";
            // 
            // Ok_AskNameUserForm_button
            // 
            this.Ok_AskNameUserForm_button.Location = new System.Drawing.Point(395, 18);
            this.Ok_AskNameUserForm_button.Name = "Ok_AskNameUserForm_button";
            this.Ok_AskNameUserForm_button.Size = new System.Drawing.Size(43, 23);
            this.Ok_AskNameUserForm_button.TabIndex = 2;
            this.Ok_AskNameUserForm_button.Text = "Ok";
            this.Ok_AskNameUserForm_button.UseVisualStyleBackColor = true;
            this.Ok_AskNameUserForm_button.Click += new System.EventHandler(this.Ok_AskNameUserForm_button_Click);
            // 
            // AskNameUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 54);
            this.Controls.Add(this.Ok_AskNameUserForm_button);
            this.Controls.Add(this.nameUser_AskNameUserForm_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AskNameUserForm";
            this.Text = "Имя пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskNameUserForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameUser_AskNameUserForm_textBox;
        private System.Windows.Forms.Button Ok_AskNameUserForm_button;
    }
}