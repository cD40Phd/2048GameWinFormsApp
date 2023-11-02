namespace _2048WindowsFormsApp
{
    partial class ResultsForm
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
            this.results_ResultsForm_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.results_ResultsForm_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // results_ResultsForm_dataGridView
            // 
            this.results_ResultsForm_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results_ResultsForm_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.results_ResultsForm_dataGridView.Location = new System.Drawing.Point(13, 13);
            this.results_ResultsForm_dataGridView.Name = "results_ResultsForm_dataGridView";
            this.results_ResultsForm_dataGridView.RowHeadersWidth = 51;
            this.results_ResultsForm_dataGridView.RowTemplate.Height = 24;
            this.results_ResultsForm_dataGridView.Size = new System.Drawing.Size(393, 404);
            this.results_ResultsForm_dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кол-во очков";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 431);
            this.Controls.Add(this.results_ResultsForm_dataGridView);
            this.Name = "ResultsForm";
            this.Text = "Результаты игр";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.results_ResultsForm_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView results_ResultsForm_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}