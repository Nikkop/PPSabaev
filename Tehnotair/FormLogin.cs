using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Tehnotair
{
    public partial class FormLogin : Form
    {
        public static int a = 1; // a переменная
        public static int b = 2; // b переменная
        public static int c = 3; // c переменная
        public static string condb = "Data Source=HOME-PC;Database=Tehnotair;Integrated security=true";
        DataSet dataSet = new DataSet();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
/*            try
            {*/
                using (SqlConnection conn = new SqlConnection(condb))
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = 
                        new SqlDataAdapter($"select * from Accounts where l={textBoxLog.Text} and passw={textBoxPas.Text}", conn);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                }

                int colCount = dataSet.Tables[0].Rows.Count;

                if (colCount > 0)
                {
                    if (dataSet.Tables[0].Rows[0][3] + "" == "admin")
                    {
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.ShowDialog();
                    }
                    else if (dataSet.Tables[0].Rows[0][3] + "" == "user")
                    {
                        FormUser formUser = new FormUser();
                        formUser.ShowDialog();
                    }
                }
                else MessageBox.Show("Неверные логин или пароль", "Ошибка");
/*            }
            catch
            {
                MessageBox.Show("Неверные логин или пароль", "Ошибка");
            }*/
        }
    }
}
