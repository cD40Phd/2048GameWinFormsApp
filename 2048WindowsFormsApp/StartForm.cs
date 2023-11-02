using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class StartForm : Form
    {
        public List<RadioButton> radioButtons;
        public StartForm()
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>
            { radioButton1, radioButton2, radioButton3, radioButton4};
        }

        private void start_StartForm_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
