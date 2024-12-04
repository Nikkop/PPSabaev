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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(FormLogin.condb))
                {
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Zakazi", con);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    dataGridViewZak.DataSource = dataSet.Tables[0];
                    dataGridViewZak.Columns[0].Visible = false;
                }
            }
            catch
            {

            }
        }
    }
}
