using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehnotair
{
    public partial class FormZakaz : Form
    {
        public FormZakaz()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection сon = new SqlConnection(FormLogin.condb))
                {
                    сon.Open();
                    SqlCommand sqlCommand = 
                        new SqlCommand($"insert into Zakazi values ({textBoxNaz.Text},{textBoxSod.Text})", сon);
                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Ваша заявка на заказ успешно создана","Создание заказа");
                Close();
            }
            catch
            {
                MessageBox.Show("В данный момент заказать недоступно", "Ошибка");
            }
        }
    }
}
