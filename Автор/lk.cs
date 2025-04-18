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
    public partial class lk : Form
    {   //Строка подключения базы данных HHruKargin.mdb
        OleDbCommand cmd;
        public static string connectionString = (@"Provider=Microsoft.Jet.Oledb.4.0;Data Source=HHruKargin.mdb");
        private OleDbConnection myConection;

        public lk()
        {
            myConection = new OleDbConnection(connectionString);
            myConection.Open();
            InitializeComponent();

            // Заполнение ComboBox'ов данными из базы данных
            string dolj_ls_querye = "SELECT DISTINCT Proffesional_direction FROM User_K";
            OleDbCommand cmdd = new OleDbCommand(dolj_ls_querye, myConection);
            OleDbDataReader rd;
            rd = cmdd.ExecuteReader();
            while (rd.Read())
            {
                string dolj = Convert.ToString(rd[0]);
                Dolj_ComboBox.Items.Add(dolj);
            }
            rd.Close();

            string ed_ls_querye = "SELECT DISTINCT Education FROM User_K";
            OleDbCommand cmddd = new OleDbCommand(ed_ls_querye, myConection);
            OleDbDataReader read;
            read = cmddd.ExecuteReader();
            while (read.Read())
            {
                string edu = Convert.ToString(read[0]);
                Education_ComboBox.Items.Add(edu);
            }
            read.Close();
        }

        private void Sumbit_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение выбранных значений из ComboBox'ов и NumericUpDown
                string dolj = Dolj_ComboBox.SelectedItem?.ToString().Trim() ?? "";
                string edu = Education_ComboBox.SelectedItem?.ToString().Trim() ?? "";
                int exp = (int)Experience_NumericUpDown.Value;


                // Строим динамический SQL-запрос в зависимости от наличия выбранных значений
                var conditions = new List<string>();

                if (!string.IsNullOrEmpty(dolj))
                {
                    conditions.Add("Proffesional_direction = @prof");
                }

                if (!string.IsNullOrEmpty(edu))
                {
                    conditions.Add("Education = @edu");
                }

                if (exp > 0)
                {
                    conditions.Add("Experience >= @exp");
                }

                // Формируем итоговый SQL-запрос
                string whereClause = string.Join(" AND ", conditions);
                string querye = "SELECT Familyname as Фамилия, name_kandidate as Имя, Surname as Отчество, Education as Образование, Proffesional_direction as Должность, Phone_number as [Номер телефона], Experience as [Опыт работы] FROM User_K";

                if (!string.IsNullOrEmpty(whereClause))
                {
                    querye += $" WHERE {whereClause}";
                }

                // Создание команды с использованием параметров
                using (OleDbCommand cmd = new OleDbCommand(querye, myConection))
                {
                    if (!string.IsNullOrEmpty(dolj))
                    {
                        cmd.Parameters.AddWithValue("@prof", dolj);
                    }

                    if (!string.IsNullOrEmpty(edu))
                    {
                        cmd.Parameters.AddWithValue("@edu", edu);
                    }

                    if (exp > 0)
                    {
                        cmd.Parameters.AddWithValue("@exp", exp);
                    }

                    // Использование OleDbDataAdapter для заполнения DataTable
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable(); // Таблица для хранения результата

                        // Заполнение таблицы данными из базы данных
                        adapter.Fill(dataTable);

                        // Привязывание таблицы к DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            //Вывод ошибок
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}