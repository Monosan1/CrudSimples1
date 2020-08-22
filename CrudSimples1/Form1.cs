using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudSimples1
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
            {

            }

        private void button5_Click(object sender, EventArgs e)
            {

            }

        private void btnConsultar_Click(object sender, EventArgs e)
            {
            string strConexao = "Data Source=DESKTOP-D0ANE1N;Initial Catalog=dbAula01;Integrated Security=True";
            string query = "select from db01";
            SqlConnection con = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            }
        }
    }
