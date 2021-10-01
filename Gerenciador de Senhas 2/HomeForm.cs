using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Windows.Documents;
using System.Drawing;
using System.Linq;

namespace Gerenciador_de_Senhas_2
{
    public partial class HomeForm : Form
    {

        private const int CS_DropShadow = 0x00020000;

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HTCAPTION = 0x2;

        private SenhaCard[] senhaCard;


        private DataTable dataTable;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public string usuario { get; set; }
        public int idUsuario { get; set; }


        public HomeForm(string usuario, int num)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.idUsuario = num;
            conta();
            atualizarComponentes(this.dataTable);

            flowLayoutPanel1.Paint += adicionarSombra;

        }



        private void conta()
        {
            Conexao c = new Conexao();
            try
            {
                c.conectar();
                string sql = "select * from Contas where usuarioID = " + idUsuario+";";
                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, c.con);
                DataTable senha = new DataTable();
                dados.Fill(senha);

                labelUsuario.Text = "Bem vindo, "+senha.Rows[0]["usuarioNome"].ToString()+" !";
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }finally
            {
                c.desconectar();
            }

        }

        private void adicionarSombra(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (SenhaCard p in panel.Controls.OfType<SenhaCard>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y, pt.X + p.Width - 1 + sp, pt.Y);
                        e.Graphics.DrawLine(pen, p.Right + sp, p.Top + sp, p.Right + sp, p.Bottom + sp);
                        pt.Y++;
                    }
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        private void atualizarComponentes(DataTable dataTable)
        {
            flowLayoutPanel1.Invalidate();
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


            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.desconectar();
            }



            if (dataTable.Rows.Count < 1)
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

            senhaCard = new SenhaCard[dataTable.Rows.Count];

            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < senhaCard.Length; i++)
            {

                senhaCard[i] = new SenhaCard();
                senhaCard[i].Id = Convert.ToInt32(dataTable.Rows[i]["ID da Senha"]);
                senhaCard[i].Nome = dataTable.Rows[i]["Nome da Senha"].ToString();
                senhaCard[i].Senha = dataTable.Rows[i]["Senha"].ToString();
                senhaCard[i].Link = dataTable.Rows[i]["Link da Senha"].ToString();
                flowLayoutPanel1.Controls.Add(senhaCard[i]);


            }

            flowLayoutPanel1.Paint += adicionarSombra;
        }



        private void novoButton_Click(object sender, EventArgs e)
        {
            int idUser = idUsuario;
            
            NovaSenhaForm f = new NovaSenhaForm(idUser);
            f.ShowDialog();
            f.Close();
            atualizarComponentes(this.dataTable);
        }

        private void editarButton_Click(object sender, EventArgs e)
        {

            int id = -1;
            int qnt = 0;
            string nome;
            string senha;
            string link;

            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (senhaCard[i].Selected)
                {
                    qnt += 1;
                }
            }
            if (qnt > 1)
            {
                MessageBox.Show("Selecione apenas um item para alterar", "Editar items", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {
                    if (senhaCard[i].Selected)
                    {
                        id = senhaCard[i].Id;
                        nome = senhaCard[i].Nome;
                        senha = senhaCard[i].Senha;
                        link = senhaCard[i].Link;
                        int idUser = idUsuario;

                        int escolha = 1;
                        NovaSenhaForm f = new NovaSenhaForm(id, idUser, nome, link, senha);
                        f.ShowDialog();
                        f.Close();
                        atualizarComponentes(this.dataTable);
                        break;
                    }
                }
                if (id == -1)
                {
                    MessageBox.Show("Selecione algum item para alterar", "Editar items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão ?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = -1;
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {
                    if (senhaCard[i].Selected)
                    {
                        id = senhaCard[i].Id;
                        Conexao c = new Conexao();

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
                        flowLayoutPanel1.Invalidate();
                    }
                }
                if (id == -1)
                {
                    MessageBox.Show("Nenhum item selecionado para a exclusão", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                atualizarComponentes(this.dataTable);
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
            if(MessageBox.Show("Deseja restaurar backup ? As informações atuais serão substituidas", "Restauração", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                atualizarComponentes(this.dataTable);
            }
            else
            {
                MessageBox.Show("Backup não encontrado !", "Restauração", MessageBoxButtons.OK);
            }
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
            else { 
                conta(); 
            }
            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }
    }
}
