using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;


namespace Gerenciador_de_Senhas_2
{
    public partial class HomeForm : Form
    {

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        public string usuario { get; set; }

        public int idUsuario {  get; set; }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        private DataTable dataTable;

        public HomeForm(string usuario, int num)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.idUsuario = num;
            conectarTabela();

        }

        private void conectarTabela()
        {
            Conexao c = new Conexao();
            try
            {
                c.conectar();

                string sql = "SELECT senhaID, senhaNome, senhaSenha, senhaLink FROM Senhas " +
                    "Where Senhas.senhaUsuario = (" +
                    "select Contas.usuarioID from Contas where Contas.usuarioLogin = '" + this.usuario + "'" +
                    ")";
                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, c.con);
                dataTable = new DataTable();
                dados.Fill(dataTable);

                dataTable.Columns[0].ColumnName = "ID da Senha";
                dataTable.Columns[1].ColumnName = "Nome da Senha";
                dataTable.Columns[2].ColumnName = "Senha";
                dataTable.Columns[3].ColumnName = "Link da Senha";

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
                    string sql = "delete from Senhas where senhaID = " + id;

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
            }
            conectarTabela();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            int idUser = idUsuario;
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
            string senha = Convert.ToString(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[2].Value);
            string link = Convert.ToString(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[3].Value);
            int idUser = idUsuario;

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
            CadastroForm f = new CadastroForm(idUsuario);
            f.Text = "Editar contas";
            f.ShowDialog();
            f.Close();
            if (f.excluiu)
            {
                LoginForm l = new LoginForm();
                this.Hide();
                l.ShowDialog();
                this.Close();

            }
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

        private void post1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
