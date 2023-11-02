using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var users = UserManager.GetAll();
            foreach ( var user in users )
            {
                results_ResultsForm_dataGridView.Rows.Add( user.Name, user.Score );
            }
        }
    }
}
