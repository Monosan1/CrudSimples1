﻿using System;
using System.Data.Sql;  
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
    public partial class txtBox2 : Form
        {
        public txtBox2()
            {
            InitializeComponent();
            }

        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
            {
            string strConexao = "Data Source=DESKTOP-D0ANE1N;Initial Catalog=dbAula01;Integrated Security=True";
            string query = "select * from tb01 where ID=" + txtBox1.Text;
            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand sqlcommand = new SqlCommand(query, con);
            SqlDataReader dr = null;

            con.Open();
            dr = sqlcommand.ExecuteReader();
            if (dr.Read())
                {
                textBox2.Text = dr["Nome"].ToString();
                }
            con.Close();

            lblStatus.Text = "Informação recuperada com Sucesso";
            }

        private void button5_Click(object sender, EventArgs e)
            {
            string strConexao = "Data Source=DESKTOP-D0ANE1N;Initial Catalog=dbAula01;Integrated Security=True";
            string query = "select * from tb01";

            }

        private void btnConsultar_Click(object sender, EventArgs e)
            {
            string strConexao = "Data Source=DESKTOP-D0ANE1N;Initial Catalog=dbAula01;Integrated Security=True";
            string query = "select * from tb01";
            SqlConnection con = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgTabela.DataSource = dt;
            }

        private void groupBox2_Enter(object sender, EventArgs e)
            {

            }

        private void dgTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void btnInsert_Click(object sender, EventArgs e)
            {
            string strConexao = "Data Source=DESKTOP-D0ANE1N;Initial Catalog=dbAula01;Integrated Security=True";
            string query = "select * from tb01";
            }

        private void btnDelete_Click(object sender, EventArgs e)
            {
            
            }

        private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

        private void txtBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

        private void label2_Click(object sender, EventArgs e)
            {

            }

        private void groupBox1_Enter(object sender, EventArgs e)
            {

            }
        }
    }
