using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WFDoNetCoreGravarDadosMySQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;

        private string data_source = "datasource = localhost; username = root; password = ; database = db_agenda";

        private int ?id_contato_selecionado = null;

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

            carregar_contatos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try 
            {
                // Conexão MySQL
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                if (id_contato_selecionado == null) {
                    // Adicionar Contato
                    cmd.CommandText = "INSERT INTO contato (nome, email, telefone) " +
                                      "VALUES (@nome, @email, @telefone) ";

                    // cmd.Prepare(); 

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato inserido com sucesso!",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    // Atualização do Contato
                    cmd.CommandText = "UPDATE contato SET nome = @nome, email = @email, telefone = @telefone " +
                                      "WHERE id = @id ";

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato atualizado com sucesso!",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                id_contato_selecionado = null;

                txtNome.Text = String.Empty;
                txtEmail.Text = "";
                txtTelefone.Text = "";

                carregar_contatos();
            } catch(MySqlException ex) {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch (Exception ex) {
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT id, nome, email, telefone FROM contato WHERE nome LIKE @contato OR email LIKE @contato";

                // cmd.Prepare();

                cmd.Parameters.AddWithValue("@contato", "%" + txtBuscarContato.Text + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

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

                    lstContatos.Items.Add(new ListViewItem(row));
                }
            } catch (MySqlException ex) {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch (Exception ex) {
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Close();
            }
        }

        private void carregar_contatos()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT id, nome, email, telefone FROM contato ORDER BY id DESC";

                // cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

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

                    lstContatos.Items.Add(new ListViewItem(row));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void lstContatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstContatos.SelectedItems;

            foreach(ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                txtNome.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            id_contato_selecionado = null;

            txtNome.Text = String.Empty;
            txtEmail.Text = "";
            txtTelefone.Text = "";

            txtNome.Focus();
        }
    }
}
