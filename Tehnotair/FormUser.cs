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
    public partial class FormUser : Form
    {
        DataSet dataSet = new DataSet();
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUser_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadGridZak();
                
            }
            catch
            {

            }
        }

        private void buttonCreateZak_Click(object sender, EventArgs e)
        {
            FormZakaz formZakaz = new FormZakaz();
            formZakaz.ShowDialog();
        }

        private void LoadGridZak()
        {
            using (SqlConnection con = new SqlConnection(FormLogin.condb))
            {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Zakazi", con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridViewZak.DataSource = dataSet.Tables[0];
                dataGridViewZak.Columns[0].Visible = false;
            }
        }
    }
}
