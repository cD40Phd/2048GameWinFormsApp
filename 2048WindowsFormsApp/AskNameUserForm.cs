using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class AskNameUserForm : Form
    {
        public AskNameUserForm()
        {
            InitializeComponent();
        }


        private void Ok_AskNameUserForm_button_Click(object sender, EventArgs e)
        {
            bool validUser = User.GetNicName(nameUser_AskNameUserForm_textBox.Text, out string outUser, out string errorMessage);

            if (!validUser)
            {
                MessageBox.Show(errorMessage);
                nameUser_AskNameUserForm_textBox.Text = "12-ть символов. Буквы или цифры";
            }
            else
            {
                Name = outUser;
                Close();
            }
        }

        private void AskNameUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Name == "AskNameUserForm") { Name = "Неизвестный"; }
        }
    }
}
