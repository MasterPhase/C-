using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassApp102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to C#", "Intro to C#", MessageBoxButtons.YesNoCancel);
        }

        private void btnHover_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("What you want?", "Hover", MessageBoxButtons.AbortRetryIgnore);
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            string name = "John Doe";
            //int number = 420;
            bool tired = false;

            object myObject = "basic";
            MessageBox.Show("Feeling Tired, " + name + "? " + tired.ToString() + " " + myObject.ToString(), "Laziness");
        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            //btnProp.Text = "Not Properties";
            //btnProp.Enabled = false;
            //btnProp.Height = 50;
            //btnProp.Width = 200;
            //txtBox.Text = "Enter value...";
            txtBox.MaxLength = 2;
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            txtBox.Show();
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string name = "Chris";
            string psw = "Pass";
            string text = txtBoxAuth.Text;
            if(txtBoxAuth.Text == name && txtBoxPsw.Text == psw) {
                MessageBox.Show("User: " + name + " is authenticated!");
                Console.WriteLine("Welcome " + name + "!");
            } else if (txtBoxAuth.Text == "Jack")
            {
                MessageBox.Show("Hi, " + txtBoxAuth.Text);
            } else
            {
                MessageBox.Show("Login Failed! Hello, " + text);
            }
        }

        private void chkBoxSub_Click(object sender, EventArgs e)
        {   //Continue if Checkbox = true

            /*
            int chris = 6;
            int brandon = 10;
            int nomthaWeed = 420;
            if (chkBox.Checked)
            {
                MessageBox.Show("The box is Checked" , "Human" , MessageBoxButtons.YesNo);
            } else
            {
                MessageBox.Show("Are you really human?");
            }

            if (txtBoxOkay.Text == "Koos")

            {
                if (chkBox.Checked)
                {
                    MessageBox.Show("Hogwarts!");
                } else
                {
                    MessageBox.Show("Humans Only");
                }
            } else
            {
                MessageBox.Show("Incorrect Phrase");
            }*/

            if (txtBoxOkay.Text == "Amberooney" && chkBox.Checked)
            {
                MessageBox.Show("Doubled Up");
            }
            else
            {
                MessageBox.Show("Incorrect Action");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            switch (txtBoxSwitch.Text)
            {
                case "TopView":
                    MessageBox.Show("Hello, TopView");
                    break;

                case "Chris":
                    MessageBox.Show("Hello, Chris");
                    break;

                case "50":
                    MessageBox.Show("Number: Fifty");
                    break;

                case "Drugs":
                    MessageBox.Show("You Drugga");
                    break;

                default:
                    MessageBox.Show("Invalid");
                    break;
            }
        }

        private void math_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(mathInputOne.Text);
            int d = Convert.ToInt32(mathInputTwo.Text);

            MessageBox.Show((c + d).ToString());
        }

        private void array_Click(object sender, EventArgs e)
        {
            //string[] Names = {"Harry","Ron","Snape" };
            //MessageBox.Show(Names[2]);
            int[] Numbers = { 5, 10, 20 };
            MessageBox.Show(Numbers[1].ToString());
        }

        private void btnLists_Click(object sender, EventArgs e)
        {
            List<string> Names = new List<string>();
            Names.Add("Jack");
            Names.Add("Jill");
            Names.Add("Goldy Goose");

            MessageBox.Show(Names[2]);
        }

        private void forEach_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("You are number " + i.ToString());
            }
            */
            string[] Names = { "Harry", "Ron", "Snape" };
            foreach (string s in Names)
            {
                MessageBox.Show(s);
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int zac = 40;

            while(zac < 50)
            {
                txtDoWhile.Text += zac.ToString();
                zac++;
            }
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            try
            {
                string[] boss = new string[2];
                string s = boss[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Code is done");
            }
            
        }

        private void btnMethods_Click(object sender, EventArgs e)
        {
            Message("Anything");
        }

        void Message(string message)
        {
            MessageBox.Show(message);
        }
    }
}
