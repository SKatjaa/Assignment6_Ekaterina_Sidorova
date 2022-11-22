using System.Diagnostics;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        private String convertNumberToComputerChoice(int numberChoice)
        {
            if (numberChoice == 1)
            {
                return "rock";
            }
            else if (numberChoice == 2)
            {
                return "paper";
            }
            else
            {
                return "scisors";
            }
        }

        private String checkTheResultOfTheGame(String userChoice, String computerChoice)
        {
            if ((computerChoice == "rock") && (userChoice == "scisors"))
            {
                return "Rock smashes scisors! Computer wins!";
            }
            else if ((userChoice == "rock") && (computerChoice == "scisors"))
            {
                return "Rock smashes scisors! You win!";
            }
            else if ((computerChoice == "scisors") && (userChoice == "paper"))
            {
                return "Scissors cut paper! Computer wins!";
            }
            else if ((userChoice == "scisors") && (computerChoice == "paper"))
            {
                return "Scissors cut paper! You win!";
            }
            else if ((computerChoice == "paper") && (userChoice == "rock"))
            {
                return "Paper wraps rock! Computer wins!";
            }
            else if ((userChoice == "paper") && (computerChoice == "rock"))
            {
                return "Paper wraps rock! You win!";
            }
            else //if (userChoice == computerChoice) 
            {
                return "Draw! Play again!";
            }
        }

        private void startTheGame(String userChoice) {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 4);
            string computerChoice = convertNumberToComputerChoice(randomNumber);
            string result = checkTheResultOfTheGame(userChoice, computerChoice);
            Debug.WriteLine(result);
            label6.Text = result;
            label6.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Text = userChoice;
            label4.Visible = true;
            label1.Text = computerChoice;
            label1.Visible = true;
        }



    public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            startTheGame("rock");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startTheGame("paper");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTheGame("scisors");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label1.Visible = false;
        }
    }
}