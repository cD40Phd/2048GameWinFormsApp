using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int mapSize;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        private int bestScore = 0;
        User user;

        private const int labelSize = 70;
        private const int padding = 6;
        private const int startX = 10;
        private const int startY = 70;

        public MainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var startForm = new StartForm();
            startForm.ShowDialog();
            
            CalculateMapSize(startForm.radioButtons);
            
            InitMap();
            GenerateNumber();
            ShowScore();
            CalculateBetsScore();
        }

        private void CalculateMapSize(List<RadioButton> radioButtons)
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    mapSize = Convert.ToInt32(radioButton.Text[0].ToString());
                    break;
                }
            }
        }

        private void CalculateBetsScore()
        {
            var users = UserManager.GetAll();
            if (users.Count == 0)
            {
                return;
            }
            bestScore = users[0].Score;
            foreach (var user in users) 
            {
                if (user.Score > bestScore) 
                { 
                    bestScore = user.Score; 
                }
                ShowBestScore();
            }

        }

        private void ShowBestScore()
        {
            
            if(score > bestScore)
            {
                bestScore = score;
            }
            bestScore_MainForm_label.Text = bestScore.ToString(); 
        }

        private void ShowScore()
        {
            score_MainForm_label.Text = score.ToString();
        }

        private void InitMap()
        {

            this.ClientSize = new System.Drawing.Size(startX + (labelSize + padding) * mapSize, startY + (labelSize + padding) * mapSize);

            labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }
        private void GenerateNumber()
        {
            bool result;
            var passedAlCells = mapSize * mapSize;
            do
            {
                var randomNumerLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumerLabel / mapSize;
                var indexColumn = randomNumerLabel % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    var randomNumber = random.Next(1,101);
                    if (randomNumber <= 75)
                    {
                        labelsMap[indexRow, indexColumn].Text = "2"; 
                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                    }
                    break;
                }
                passedAlCells--;
                result = (passedAlCells >= 0);
            } while (result);
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = Color.FromArgb(224, 224, 224);
            label.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(labelSize, labelSize);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = startX + indexColumn * (labelSize + padding);
            int y = startY + indexRow * (labelSize + padding);
            label.Location = new Point(x, y);
            label.TextChanged += Label_TextChanged;
            return label;
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            var label = (Label)sender;
            switch(label.Text)
            {
                case "": label.BackColor = Color.FromArgb(224, 224, 224); break;
                case "2": label.BackColor = Color.FromArgb(250, 240, 230); break;
                case "4": label.BackColor = Color.FromArgb(255, 240, 245); break;
                case "8": label.BackColor = Color.FromArgb(255, 228, 225); break;
                case "16": label.BackColor = Color.FromArgb(255, 218, 185); break;
                case "32": label.BackColor = Color.FromArgb(255, 222, 173); break;
                case "64": label.BackColor = Color.FromArgb(255, 228, 181); break;
                case "128": label.BackColor = Color.FromArgb(188, 143, 143); break;
                case "256": label.BackColor = Color.FromArgb(210, 180, 140); break;
                case "512": label.BackColor = Color.FromArgb(222, 184, 135); break;
                case "1024": label.BackColor = Color.FromArgb(244, 164, 96); break;
                case "2048": label.BackColor = Color.FromArgb(205, 133, 63); break;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down) return;
            
            if (e.KeyCode == Keys.Right)
            {
                MoveLabelRight();
            }
            if (e.KeyCode == Keys.Left)
            {
                MoveLabelLeft();
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveLabelUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveLabelDown();
            }
            GenerateNumber();
            ShowScore();
            ShowBestScore();

            if (Win())
            {
                var Name = User.AskNameUser();
                user = new User(Name, score );
                UserManager.Add(user);
                MessageBox.Show($"{user.Name} вы победили! 🤩");;
                Application.Restart();
            }

            if(EndGame())
            {
                var Name = User.AskNameUser();
                user = new User(Name, score);
                UserManager.Add(user);
                MessageBox.Show($"К сожалению, игра проиграна, {user.Name} 😞");
                Application.Restart();
            }
        }

        private bool EndGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "")
                    { return false; }
                }
            }

            for (int i = 0; i <= mapSize - 1; i++)
            {
                for (int j = 0; j <= mapSize - 1; j++)
                {
                    if (j < mapSize - 1 && labelsMap[i, j].Text == labelsMap[i, j + 1].Text || i < mapSize - 1 && labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool Win()
        {
            for(int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i,j].Text == "2048")
                    { return true;  }
                }
            }
            return false;
        }

        private void MoveLabelDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLabelUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLabelLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLabelRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила игры '2048'\n\nКонечная цель игры — плитка с цифрами 2048. Добиться таких результатов, можно лишь одним способом, а именно просчитывая все ходы наперед.\n\nРазберём подробно, как играть 2048, начнем с простых правил. Так, например, в начале игры вам выдается плитка с цифрой «2», нажимая кнопочку вверх, вправо, влево или вниз, все ваши кирпичики будут смещаться в ту же сторону. Но, при соприкосновении клеточек с одним и тем же номиналом, они объединяются и создают сумму вдвое больше.\n\nРассмотрим на примере основное правило. Так, допустим, у вас два кирпичика «2», сместите их так, чтобы они находились рядом и повторите процедуру, пока у вас не получиться цифра «4». Получилось? Дальше необходимо действовать тем же способом и теперь уже собирать клеточку «8» из двух «4». Для того чтобы играть 2048 на компьютере достаточно лишь нажать клавишу влево, вправо, вверх или вниз. Игра заканчивается тогда, когда все пустые ячейки заполнены, и вы больше не можете передвигать клеточки ни в одну из сторон.\nНу, или когда на одном из кубов, наконец, появилась заветная цифра 2048.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void начатьЗановаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
