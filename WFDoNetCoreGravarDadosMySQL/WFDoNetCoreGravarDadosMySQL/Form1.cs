using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WFDoNetCoreGravarDadosMySQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;

        private string data_source = "datasource = localhost; username = root; password = ; database=db_agenda";

        public Form1()
        {
            InitializeComponent();

            lstContatos.View = View.Details;
            lstContatos.LabelEdit = true;
            lstContatos.AllowColumnReorder = true;
            lstContatos.FullRowSelect = true;
            lstContatos.GridLines = true;

            lstContatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try 
            {
                // Criar conexão com MySQL
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO contato (nome, email, telefone) " +
                             "VALUES ('" + txtNome.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "')";

                // Executar Comando Insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Deu tudo certo! Inserido os dados.");
            } catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } finally {
                Conexao.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "'%" + txtBuscarContato.Text + "%'"; 

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                             "FROM contato " +
                             "WHERE nome LIKE " + query + "OR email LIKE " + query;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                lstContatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    };

                    var linha_listview = new ListViewItem(row);

                    lstContatos.Items.Add(linha_listview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                Conexao.Close();
            }
        }
    }
}
