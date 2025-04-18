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

namespace Авторизация
{
    public partial class Form3 : Form
    {
        //Строка подключения к базе данных HHruKargin.mdb
        OleDbCommand cmd;
        public static string connectionString = (@"Provider=Microsoft.Jet.Oledb.4.0;Data Source=HHruKargin.mdb");
        private OleDbConnection myConection;
        public Form3()
        {
            InitializeComponent();
            myConection = new OleDbConnection(connectionString);
            myConection.Open();
        }

        private void Form3_Load(object sender, EventArgs e)
        {   
            //Создание обработчиков событий
            this.Company_name_TextBox.Enter += new EventHandler(Company_name_TextBox_Enter);
            this.Company_name_TextBox.Leave += new EventHandler(Company_name_TextBox_Leave);

            this.Login_TextBox.Enter += new EventHandler(Login_TextBox_Enter);
            this.Login_TextBox.Leave += new EventHandler(Login_TextBox_Leave);

            this.Password_TextBox.Enter += new EventHandler(Password_TextBox_Enter);
            this.Password_TextBox.Leave += new EventHandler(Password_TextBox_Leave);

            this.Email_TextBox.Enter += new EventHandler(Email_TextBox_Enter);
            this.Email_TextBox.Leave += new EventHandler(Email_TextBox_Leave);

            this.Phone_number_TextBox.Enter += new EventHandler(Phone_number_TextBox_Enter);
            this.Phone_number_TextBox.Leave += new EventHandler(Phone_number_TextBox_Leave);

            this.Button_Registration.Click += new EventHandler(Button_Registration_Click);
        }
        //Создание методов TextBox подсказок
        private void Company_name_TextBox_Enter(object sender, EventArgs e)
        {
            if (Company_name_TextBox.Text == "Enter your company name")
            {
                Company_name_TextBox.Text = "";
                Company_name_TextBox.ForeColor = Color.Black;
            }
        }
        private void Company_name_TextBox_Leave(object sender, EventArgs e)
        {
            if (Company_name_TextBox.Text == "")
            {
                Company_name_TextBox.Text = "Enter your company name";
                Company_name_TextBox.ForeColor = Color.Silver;
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
        private void Email_TextBox_Enter(object sender, EventArgs e)
        {
            if (Email_TextBox.Text == "Enter your email")
            {
                Email_TextBox.Text = "";
                Email_TextBox.ForeColor = Color.Black;
            }
        }
        private void Email_TextBox_Leave(object sender, EventArgs e)
        {
            if (Email_TextBox.Text == "")
            {
                Email_TextBox.Text = "Enter your email";
                Email_TextBox.ForeColor = Color.Silver;
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
        private void Button_Registration_Click(object sender, EventArgs e)
        {
            //Присвоение переменным значений TextBox
            string cn = Company_name_TextBox.Text;

            string lg = Login_TextBox.Text;

            string ps = Password_TextBox.Text;

            string em = Email_TextBox.Text;

            string pn = Phone_number_TextBox.Text;

            if (string.IsNullOrEmpty(Company_name_TextBox.Text) || string.IsNullOrEmpty(Login_TextBox.Text) || string.IsNullOrEmpty(Password_TextBox.Text) || string.IsNullOrEmpty(Email_TextBox.Text) || string.IsNullOrEmpty(Phone_number_TextBox.Text) || (Company_name_TextBox.Text == "Enter your company name") || (Login_TextBox.Text == "Come up with your login") || (Password_TextBox.Text == "Come up with your password") || (Email_TextBox.Text == "Enter your email") || (Phone_number_TextBox.Text == "Enter your phone number"))
            {
                //Проверка на заполнение всех данных
                MessageBox.Show("Введены не все данные!");
            }
            else
            {
                //SQL-запрос - выбор данных таблицы авторизации
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
                    //Проверка на уникальность логина
                    MessageBox.Show("Пользователь с данным логином уже существует!");
                }
                else
                {
                    //Ввод данных в таблицу Компаний
                    string querye = "Insert into User_C (id, id_company, Company_name, Email, Phone_number) values (@код, @кодк, @нк, @мыло, @тел)";
                    cmd = new OleDbCommand(querye, myConection);
                    cmd.Parameters.AddWithValue("@код", Convert.ToInt32(Id_TextBox.Text));
                    cmd.Parameters.AddWithValue("@кодк", Convert.ToInt32(Id_TextBox.Text));
                    cmd.Parameters.AddWithValue("@нк", Company_name_TextBox.Text);
                    cmd.Parameters.AddWithValue("@мыло", Email_TextBox.Text);
                    cmd.Parameters.AddWithValue("@тел", Phone_number_TextBox.Text);
                    cmd.ExecuteNonQuery();

                    //Ввод данных в таблицу авторизации
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
            //Автозаполнение TextBox'а id
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
    
