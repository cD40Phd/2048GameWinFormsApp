namespace _2048WindowsFormsApp
{
    public class User
    {
        public string Name;
        public int Score;

        public User(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public static string AskNameUser()
        {
            var AskNameUserForm = new AskNameUserForm();
            AskNameUserForm.ShowDialog();
            return AskNameUserForm.Name;
        }

        public static bool GetNicName(string userName, out string outUserName, out string messagedError)
        {
            if (userName != null && IsNotValidNik(userName))
            {
                outUserName = userName;
                messagedError = null;
                return true;
            }
            else
            {
                outUserName = null;
                messagedError = "\nВнимание!\n" +
                "Веденные данные не выполняют условий\nПопробуйте ввести заново";
                return false;
            }
        }

        public static bool IsNotValidNik(string userName)
        {
            if (userName.Length > 12 || userName.Length < 2)
            {
                return false;
            }

            foreach (char c in userName)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }


}
