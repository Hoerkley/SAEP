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
    public partial class TelaConfirmarVenda : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=CarShopping;User ID=sa;Password=sql2022";
        SqlConnection conexao;
        public TelaConfirmarVenda()
        {
            InitializeComponent();
        }

        private void TelaConfirmarVenda_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cliente", strConexao);
            DataTable tabela = new DataTable();
            da.Fill(tabela);
            cmbCliente.DataSource = tabela;
            cmbCliente.DisplayMember = "nomePeca";
            cmbCliente.ValueMember = "codigo";

        }
    }
}
