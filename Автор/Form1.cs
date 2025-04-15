using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Авторизация
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Login_TextBox.Enter += new EventHandler(Login_TextBox_Enter);
            this.Login_TextBox.Leave += new EventHandler(Login_TextBox_Leave);

            this.Password_TextBox.Enter += new EventHandler(Password_TextBox_Enter);
            this.Password_TextBox.Leave += new EventHandler(Password_TextBox_Leave);
        }
        private void Login_TextBox_Enter(object sender, EventArgs e)
        {
            if (Login_TextBox.Text == "Enter your login")
            {
                Login_TextBox.Text = "";
                Login_TextBox.ForeColor = Color.Black;
            }
          
        }
        private void Login_TextBox_Leave(object sender, EventArgs e)
        {
            if (Login_TextBox.Text == "")
            {
                Login_TextBox.Text = "Enter your login";
                Login_TextBox.ForeColor = Color.Silver;
            }
        }

        private void Password_TextBox_Enter(object sender, EventArgs e)
        {
            if (Password_TextBox.Text == "Enter your password")
            {
                Password_TextBox.Text = "";
                Password_TextBox.ForeColor = Color.Black;
                Password_TextBox.UseSystemPasswordChar = true;
            }
        }
        private void Password_TextBox_Leave(object sender, EventArgs e)
        {
            if (Password_TextBox.Text == "")
            {
                Password_TextBox.Text = "Enter your password";
                Password_TextBox.ForeColor = Color.Silver;
                Password_TextBox.UseSystemPasswordChar = false;
            }
        }

        private void Button_Authorization_Click(object sender, EventArgs e)
        {

            string usr = Login_TextBox.Text;
            string psw = Password_TextBox.Text;
            string connectionString = (@"Provider=Microsoft.Jet.Oledb.4.0;Data Source=HHruKargin.mdb");
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Autorization WHERE Login = @login AND Password = @password";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", usr);
                    command.Parameters.AddWithValue("@password", psw);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Добро пожаловать " + Login_TextBox.Text);
                        lk f1 = new lk();
                        f1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль");
                    }
                }
                connection.Close();
            }
        }

        private void LinkLabel_Registration_for_Candidate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 Registration = new Form2();
            Registration.Show();
            
        }

        private void LinkLabel_Registration_for_employer_company_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 Registration = new Form3();
            Registration.Show();
        }
    }
}
