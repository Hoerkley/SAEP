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

namespace CarShopping
{
    public partial class TelaVenda : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=CarShopping;User ID=sa;Password=sql2022";
        SqlConnection conexao;
        public int area;

        public TelaVenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaVenda_Load(object sender, EventArgs e)
        {
            lblArea.Text = area.ToString();
        }

        private void btnVender1_Click(object sender, EventArgs e)
        {
            TelaConfirmarVenda form = new TelaConfirmarVenda();
            form.ShowDialog();
        }
    }
}
