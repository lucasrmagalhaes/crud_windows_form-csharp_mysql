using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WFDoNetCoreGravarDadosMySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                string data_source = "datasource = localhost; username = root; password = ; database=db_agenda";

                // Criar conexão com MySQL
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO contato (nome, email, telefone) " +
                             "VALUES ('" + txtNome.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "')";

                // Executar Comando Insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Deu tudo certo! Inserido os dados.");
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                Conexao.Close();
            }
        }
    }
}
