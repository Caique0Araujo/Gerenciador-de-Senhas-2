using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
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
            CarregarConta();
            AtualizarComponentes(dataTable);

            flowLayoutPanel1.Paint += AdicionarSombra;

        }



        private void CarregarConta()
        {
            Conexao c = new Conexao();
            try
            {
                c.conectar();
                string sql = "select * from Contas where usuarioID = " + idUsuario + ";";
                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, c.con);
                DataTable senha = new DataTable();
                dados.Fill(senha);

                labelUsuario.Text = "Bem vindo, " + senha.Rows[0]["usuarioNome"].ToString() + " !";
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                c.desconectar();
            }

        }

        private void AdicionarSombra(object sender, PaintEventArgs e)
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

        private void AtualizarComponentes(DataTable dataTable)
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

            flowLayoutPanel1.Paint += AdicionarSombra;
        }

       

        private void NovaSenha(object sender, EventArgs e)
        {
            int idUser = idUsuario;

            NovaSenhaForm f = new NovaSenhaForm(idUser);
            f.ShowDialog();
            f.Close();
            AtualizarComponentes(this.dataTable);
        }

        private void EditarSenha(object sender, EventArgs e)
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
                        AtualizarComponentes(this.dataTable);
                        break;
                    }
                }
                if (id == -1)
                {
                    MessageBox.Show("Selecione algum item para alterar", "Editar items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ExcluirSenha(object sender, EventArgs e)
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
                AtualizarComponentes(this.dataTable);
            }
        }


        private void FazerBackup(object sender, EventArgs e)
        {

            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            string backupFolder = Path.Combine(dialog.SelectedPath, "BACKUP");
            string backupZip = Path.Combine(dialog.SelectedPath, "Backup.zip");

            Directory.CreateDirectory(backupFolder);

            string destfile = Path.Combine(backupFolder, "DBsenhasBP.db");

            File.Copy(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DBsenhas.db"), destfile);

            if (File.Exists(backupZip))
            {
                File.Delete(backupZip);
            }

            ZipFile.CreateFromDirectory(backupFolder, backupZip);

            File.Delete(destfile);
            Directory.Delete(backupFolder);

            if (File.Exists(backupZip))
                MessageBox.Show("Backup criado com sucesso !", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  

        }
        private void RestaurarBackup(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();


            var dialog = new OpenFileDialog();

            dialog.Title = "Escolher arquivo de backup";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                var backupFile = dialog.FileName;
                string backupPath = Path.GetDirectoryName(backupFile);

                var srcFile = Path.Combine(backupPath, "DBsenhasBP.db");
                var destFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DBsenhas.db");


                if (File.Exists(backupFile))
                {
                    ZipFile.ExtractToDirectory(backupFile, backupPath);

                    if (File.Exists(destFile))
                        File.Delete(destFile);

                    File.Copy(srcFile, destFile);

                    File.Delete(srcFile);

                    MessageBox.Show("Backup restaurado com sucesso !", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("Backup não encontrado !", "Restauração", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nenhum arquivo selecionado !", "Restauração", MessageBoxButtons.OK);

            }


            AtualizarComponentes(this.dataTable);

        }



        private void ArrastarJanela(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void MinimizarJanela(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FecharJanela(object sender, EventArgs e)
        {
            Close();
        }



        private void EditarConta(object sender, EventArgs e)
        {
            CadastroForm f = new CadastroForm(idUsuario);
            f.Text = "Editar contas";
            f.ShowDialog();
            f.Close();
            if (f.Excluiu)
            {
                LoginForm l = new LoginForm();
                this.Hide();
                l.ShowDialog();
                this.Close();

            }
            else
            {
                CarregarConta();
            }

        }

        private void SairConta(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void AbrirInfo(object sender, EventArgs e)
        {
            MessageBox.Show("Este é o Gerenciador de Senhas, aplicativo desenvolvido pelo Caique Figueiredo de Araújo.\n"
                + "Para mais informações acesse o arquivo de texto info.txt na pasta raiz do programa.\n"
                + "Agradecimentos especiais ao Ferreira, o mago do C#.\n",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void senhaCard1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
