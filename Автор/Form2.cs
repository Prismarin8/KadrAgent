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
using System.Collections;

namespace Авторизация
{
    public partial class Form2 : Form 
    {
        OleDbCommand cmd;
        public static string connectionString = (@"Provider=Microsoft.Jet.Oledb.4.0;Data Source=HHruKargin.mdb");
        private OleDbConnection myConection;
        
        public Form2()
        {
            InitializeComponent();
            myConection = new OleDbConnection(connectionString);
            myConection.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

                this.Familyname_TextBox.Enter += new EventHandler(Familyname_TextBox_Enter);
                this.Familyname_TextBox.Leave += new EventHandler(Familyname_TextBox_Leave);

                this.Name_TextBox.Enter += new EventHandler(Name_TextBox_Enter);
                this.Name_TextBox.Leave += new EventHandler(Name_TextBox_Leave);

                this.Surname_TextBox.Enter += new EventHandler(Surname_TextBox_Enter);
                this.Surname_TextBox.Leave += new EventHandler(Surname_TextBox_Leave);

                this.Login_TextBox.Enter += new EventHandler(Login_TextBox_Enter);
                this.Login_TextBox.Leave += new EventHandler(Login_TextBox_Leave);

                this.Password_TextBox.Enter += new EventHandler(Password_TextBox_Enter);
                this.Password_TextBox.Leave += new EventHandler(Password_TextBox_Leave);

                this.Education_TextBox.Enter += new EventHandler(Education_TextBox_Enter);
                this.Education_TextBox.Leave += new EventHandler(Education_TextBox_Leave);

                this.Professional_direction_TextBox.Enter += new EventHandler(Professional_direction_TextBox_Enter);
                this.Professional_direction_TextBox.Leave += new EventHandler(Professional_direction_TextBox_Leave);

                this.Phone_number_TextBox.Enter += new EventHandler(Phone_number_TextBox_Enter);
                this.Phone_number_TextBox.Leave += new EventHandler(Phone_number_TextBox_Leave);

                this.Experience_TextBox.Enter += new EventHandler(Experience_TextBox_Enter);
                this.Experience_TextBox.Leave += new EventHandler(Experience_TextBox_Leave);
        }
        private void Familyname_TextBox_Enter(object sender, EventArgs e)
        {
            if (Familyname_TextBox.Text == "Enter your familyname")
                {
                Familyname_TextBox.Text = "";
                Familyname_TextBox.ForeColor = Color.Black;
            }
        }
        private void Familyname_TextBox_Leave(object sender, EventArgs e)
        {
            if (Familyname_TextBox.Text == "")
                {
                Familyname_TextBox.Text = "Enter your familyname";
                Familyname_TextBox.ForeColor = Color.Silver;
            }
        }
        private void Name_TextBox_Enter(object sender, EventArgs e)
        {
            if (Name_TextBox.Text == "Enter your name")
            {
                Name_TextBox.Text = "";
                Name_TextBox.ForeColor = Color.Black;
            }
        }
        private void Name_TextBox_Leave(object sender, EventArgs e)
        {
            if (Name_TextBox.Text == "")
            {
                Name_TextBox.Text = "Enter your name";
                Name_TextBox.ForeColor = Color.Silver;
            }
        }
        private void Surname_TextBox_Enter(object sender, EventArgs e)
        {
            if (Surname_TextBox.Text == "Enter your surname")
            {
                Surname_TextBox.Text = "";
                Surname_TextBox.ForeColor = Color.Black;
            }
        }
        private void Surname_TextBox_Leave(object sender, EventArgs e)
        {
            if (Surname_TextBox.Text == "")
            {
                Surname_TextBox.Text = "Enter your surname";
                Surname_TextBox.ForeColor = Color.Silver;
            }
        }
        private void Login_TextBox_Enter(object sender, EventArgs e)
        {
            if (Login_TextBox.Text == "Come up with your login")
            {
                Login_TextBox.Text = "";
                Login_TextBox.ForeColor = Color.Black;
            }
        }
        private void Login_TextBox_Leave(object sender, EventArgs e)
        {
            if (Login_TextBox.Text == "")
            {
                Login_TextBox.Text = "Come up with your login";
                Login_TextBox.ForeColor = Color.Silver;
            }
        }
        private void Password_TextBox_Enter(object sender, EventArgs e)
        {
            if (Password_TextBox.Text == "Come up with your password")
            {
                Password_TextBox.Text = "";
                Password_TextBox.ForeColor = Color.Black;
            }
        }
        private void Password_TextBox_Leave(object sender, EventArgs e)
        {
            if (Password_TextBox.Text == "")
            {
                Password_TextBox.Text = "Come up with your password";
                Password_TextBox.ForeColor = Color.Silver;
            }
        }
        private void Education_TextBox_Enter(object sender, EventArgs e)
        {
            if (Education_TextBox.Text == "Enter your education")
            {
                Education_TextBox.Text = "";
                Education_TextBox.ForeColor = Color.Black;
            }
        }
        private void Education_TextBox_Leave(object sender, EventArgs e)
        {
            if (Education_TextBox.Text == "")
            {
                Education_TextBox.Text = "Enter your education";
                Education_TextBox.ForeColor = Color.Silver;
            }
        }
        private void Professional_direction_TextBox_Enter(object sender, EventArgs e)
        {
            if (Professional_direction_TextBox.Text == "Enter your professional direction")
            {
                Professional_direction_TextBox.Text = "";
                Professional_direction_TextBox.ForeColor = Color.Black;
            }
        }
        private void Professional_direction_TextBox_Leave(object sender, EventArgs e)
        {
            if (Professional_direction_TextBox.Text == "")
            {
                Professional_direction_TextBox.Text = "Enter your professional direction";
                Professional_direction_TextBox.ForeColor = Color.Silver;
            }
        }
        private void Phone_number_TextBox_Enter(object sender, EventArgs e)
        {
            if (Phone_number_TextBox.Text == "Enter your phone number")
            {
                Phone_number_TextBox.Text = "";
                Phone_number_TextBox.ForeColor = Color.Black;
            }
        }
        private void Phone_number_TextBox_Leave(object sender, EventArgs e)
        {
            if (Phone_number_TextBox.Text == "")
            {
                Phone_number_TextBox.Text = "Enter your phone number";
                Phone_number_TextBox.ForeColor = Color.Silver;
              
            }
        }
        private void Experience_TextBox_Enter(object sender, EventArgs e)
        {
            if (Experience_TextBox.Text == "Enter your experience")
            {
                Experience_TextBox.Text = "";
                Experience_TextBox.ForeColor = Color.Black;
            }
        }
        private void Experience_TextBox_Leave(object sender, EventArgs e)
        {
            if (Experience_TextBox.Text == "")
            {
                Experience_TextBox.Text = "Enter your experience";
                Experience_TextBox.ForeColor = Color.Silver;
            }
        }

        private void Button_Registration_Click(object sender, EventArgs e)
        {

            string fm = Familyname_TextBox.Text;

            string n = Name_TextBox.Text;

            string sn = Surname_TextBox.Text;

            string lg = Login_TextBox.Text;

            string ps = Password_TextBox.Text;

            string ed = Education_TextBox.Text;

            string pd= Professional_direction_TextBox.Text;
            string pn = Phone_number_TextBox.Text;
            if (string.IsNullOrEmpty(Familyname_TextBox.Text) || string.IsNullOrEmpty(Experience_TextBox.Text) || string.IsNullOrEmpty(Name_TextBox.Text) || string.IsNullOrEmpty(Surname_TextBox.Text) ||
            string.IsNullOrEmpty(Login_TextBox.Text) || string.IsNullOrEmpty(Password_TextBox.Text) || string.IsNullOrEmpty(Education_TextBox.Text) || string.IsNullOrEmpty(Professional_direction_TextBox.Text) || string.IsNullOrEmpty(Phone_number_TextBox.Text)
            || (Familyname_TextBox.Text == "Enter your familyname") || (Experience_TextBox.Text == "Enter your experience") || (Name_TextBox.Text == "Enter your name") || (Surname_TextBox.Text == "Enter your surname") ||
            (Login_TextBox.Text == "Come up with your login") || (Password_TextBox.Text == "Come up with your password") || (Education_TextBox.Text == "Enter your education") || (Professional_direction_TextBox.Text == "Enter your professional direction") || (Phone_number_TextBox.Text == "Enter your phone number"))
            {
                MessageBox.Show("Введены не все данные!");
            }
            else
            {
                string lg_ls_querye = "SELECT Login FROM Autorization";
                OleDbCommand cmdd = new OleDbCommand(lg_ls_querye, myConection);
                OleDbDataReader rd;
                rd = cmdd.ExecuteReader();
                bool isLoginExists = false;
                while (rd.Read())
                {
                    string log = Convert.ToString(rd[0]);

                    if (lg == log)
                    {
                        isLoginExists = true;
                        break;
                    }
                }
                if (isLoginExists)
                {
                    MessageBox.Show("Пользователь с данным логином уже существует!");
                }
                else
                {
                    string querye = "Insert into User_K (id, id_kandidate, Familyname, name_kandidate, Surname, Education, Proffesional_direction, Phone_number, Experience) values (@код, @кодк, @фам, @имя, @отч, @обр, @направ, @тел, @exp)";
                    cmd = new OleDbCommand(querye, myConection);
                    cmd.Parameters.AddWithValue("@код", Convert.ToInt32(Id_TextBox.Text));
                    cmd.Parameters.AddWithValue("@кодк", Convert.ToInt32(Id_TextBox.Text));
                    cmd.Parameters.AddWithValue("@фам", Familyname_TextBox.Text);
                    cmd.Parameters.AddWithValue("@имя", Name_TextBox.Text);
                    cmd.Parameters.AddWithValue("@отч", Surname_TextBox.Text);
                    cmd.Parameters.AddWithValue("@обр", Education_TextBox.Text);
                    cmd.Parameters.AddWithValue("@направ", Professional_direction_TextBox.Text);
                    cmd.Parameters.AddWithValue("@тел", Phone_number_TextBox.Text);
                    cmd.Parameters.AddWithValue("@exp", Experience_TextBox.Text);
                    cmd.ExecuteNonQuery();

                    string autoriz = "Insert into Autorization (id, Login, [Password]) values (@id, @log, @pas)";
                    cmd = new OleDbCommand(autoriz, myConection);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Id_TextBox.Text));
                    cmd.Parameters.AddWithValue("@log", Login_TextBox.Text);
                    cmd.Parameters.AddWithValue("@pas", Password_TextBox.Text);
                    cmd.ExecuteNonQuery();
                }
                
            }
            Close();
        }

        private void Id_TextBox_Click(object sender, EventArgs e)
        {
            string com = "SELECT id FROM Autorization";
            OleDbCommand cmdd = new OleDbCommand(com, myConection);
            OleDbDataReader rd;
            rd = cmdd.ExecuteReader();
            while (rd.Read())
            {
                int r = Convert.ToInt32(rd[0]) + 1;
                Id_TextBox.Text = r.ToString();
            }
        }


    }
    
}
