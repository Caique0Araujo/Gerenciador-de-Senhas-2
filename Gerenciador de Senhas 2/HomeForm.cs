using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.IO.Compression;


namespace Gerenciador_de_Senhas_2
{
    public partial class HomeForm : Form
    {

        public string usuario { get; set; }

        private int usuarioID;
        public HomeForm(string usuario, int num)
        {
            InitializeComponent();
            this.usuario = usuario;
            conectarTabela();
            this.usuarioID = num;

        }

        private void conectarTabela()
        {
            Conexao c = new Conexao();
            try
            {
                c.conectar();

                string sql = "SELECT senhaNome, senhaSenha, senhaLink FROM Senhas " +
                    "Where Senhas.senhaUsuario = (" +
                    "select Contas.usuarioID from Contas where Contas.usuarioLogin = '" + this.usuario + "'" +
                    ");";
                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, c.con);
                DataTable dataTable = new DataTable();
                dados.Fill(dataTable);

                dataTable.Columns[0].ColumnName = "Nome da Senha";
                dataTable.Columns[1].ColumnName = "Senha";
                dataTable.Columns[2].ColumnName = "Link da Senha";

                dataGridView.DataSource = dataTable;

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.desconectar();
            }

            c.desconectar();

            if (dataGridView.Rows.Count < 1)
            {
                editarButton.Enabled = false;
                novoButton.Enabled = true;
                excluirButton.Enabled = false;
            }
            else
            {
                editarButton.Enabled = true;
                excluirButton.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value);
            Conexao c = new Conexao();

            if (MessageBox.Show("Confirma a exclusão ?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    c.conectar();
                    string sql = "delete from Senhas where senhaID = " + id+";";

                    SQLiteCommand command = new SQLiteCommand(sql, c.con);
                    command.ExecuteNonQuery();
               
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    c.desconectar();
                }
                c.desconectar();
            }
            conectarTabela();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            int idUser = this.usuarioID;
            //Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[3].Value);
            NovaSenhaForm f = new NovaSenhaForm(idUser);
            f.ShowDialog();
            f.Close();
            conectarTabela();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value);
            string nome = Convert.ToString(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[1].Value);
            string link = Convert.ToString(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[2].Value);
            int idUser = Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[3].Value);
            string senha = Convert.ToString(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[4].Value);

            int escolha = 1;
            NovaSenhaForm f = new NovaSenhaForm(id, idUser, nome, link, senha);
            f.ShowDialog();
            f.Close();
            conectarTabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.ShowDialog();
            this.Close();

        }

        private void editarContaButton_Click(object sender, EventArgs e)
        {
            CadastroForm f = new CadastroForm(usuarioID);
            f.Text = "Editar contas";
            f.ShowDialog();
            f.Close();
        }

        private void exportarButton_Click(object sender, EventArgs e)
        {

            if (File.Exists("./DBSenhas.db"))
            {
                if (File.Exists("./Backup.zip"))
                    File.Delete("./Backup.zip");

                Directory.CreateDirectory("./BACKUP");
                File.Copy("./DBSenhas.db", "./BACKUP/DBSenhas.db", true);
                ZipFile.CreateFromDirectory("./BACKUP", "./Backup.zip");
                File.Delete("./BACKUP/DBSenhas.db");
                Directory.Delete("./BACKUP");
            }
            if (File.Exists("./Backup.zip"))
                MessageBox.Show("Backup criado com sucesso !", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {

            if (File.Exists("./Backup.zip"))
            {
                if (File.Exists("./DBSenhas.db"))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete("./DBSenhas.db");
                }
                ZipFile.ExtractToDirectory("./Backup.zip", "./");
                MessageBox.Show("Backup restaurado com sucesso !", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conectarTabela();
            }
            else
            {
                MessageBox.Show("Backup não encontrado !", "Restauração", MessageBoxButtons.OK);
            }
        }
    }
}
