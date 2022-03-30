namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int left;
        int right;
        int result;
        int userText;
        int second = 15;
        Random randomNumber = new Random();

        public Form1()
        {
            InitializeComponent();
            GenerateExpression();
            timer1.Start();
            progressBarText.Text = progressBar1.Value + " /10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void GenerateExpression()
        {
            left = randomNumber.Next(0,10);
            right = randomNumber.Next(0, 10);
            result = left + right;

            operandLeft.Text = left.ToString();
            operandRight.Text = right.ToString();   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ResultUser();
            GenerateExpression();
            
        }

        //private void Enter(object sender, KeyPressEventArgs e)
        //{
           
        //}

        public void ResultUser()
        {
            userText = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            if (userText == result)
            {
                YouWin();
            }
            else
            {
                YouLost();
            }
        }

        private void YouWin()
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Вы победили", "Поздравляем");
                Close();
                return;
            }
            second = 15;
            progressBar1.Value += 1;
            progressBarText.Text = progressBar1.Value + " /10";
        }

        private void YouLost()
        {
            if (progressBar1.Value == 0)
            {
                timer1.Stop();
                MessageBox.Show("Вы проиграли", "НЕ поздравляем");
                Close();
                return;
            }
            second = 15;
            progressBar1.Value -= 1;
            progressBarText.Text = progressBar1.Value + " /10";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ResultUser();
                GenerateExpression();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second -= 1;
            if (second >= 0)
            {
                if (second <= 5) { timerShow.ForeColor = Color.Red; }
                timerShow.Text = Convert.ToString(second);
            }
            else
            {
                timerShow.ForeColor = Color.LawnGreen;
                second = 15;
                GenerateExpression();
                YouLost();
            }
            
        }
    }
}