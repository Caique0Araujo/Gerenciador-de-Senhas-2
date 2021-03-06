using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Gerenciador_de_Senhas_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            VerificarMarcado();

        }

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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        private int ObterUsuarioId()
        {
            Conexao con = new Conexao();
            try
            {
                con.conectar();

                string sql = "Select usuarioID from Contas where usuarioLogin = '" + usuarioTextBox.Text + "';";
                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, con.con);
                DataTable Ids = new DataTable();
                dados.Fill(Ids);

                int id = Convert.ToInt32(Ids.Rows[0]["usuarioID"]);

                return id;

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.desconectar();
            }

            return 0;

        }

        private bool VerificarUsuario()
        {
            Conexao con = new Conexao();
            try
            {
                con.conectar();

                string sql = "Select usuarioLogin from Contas where usuarioLogin = '" + usuarioTextBox.Text + "'";
                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, con.con);
                DataTable usuario = new DataTable();
                dados.Fill(usuario);

                if (usuario.Rows.Count < 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.desconectar();
            }


            return false;
        }

        private bool VerificarSenha()
        {
            Conexao con = new Conexao();
            try
            {
                con.conectar();

                string sql = "Select usuarioSenha from Contas where usuarioSenha = '" + senhaTextBox.Text + "' AND usuarioLogin = '" + usuarioTextBox.Text + "';";
                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, con.con);
                DataTable senha = new DataTable();
                dados.Fill(senha);

                if (senha.Rows.Count < 1)
                {
                    con.desconectar();
                    return false;
                }
                else
                {
                    con.desconectar();
                    return true;
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.desconectar();
            }

            return false;
        }

        private void VerificarMarcado()
        {

            Conexao con = new Conexao();
            try
            {
                con.conectar();

                string sql = "Select * from Contas where usuarioConectado = 1;";
                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, con.con);
                DataTable senha = new DataTable();
                dados.Fill(senha);

                if (senha.Rows.Count < 1)
                {
                    con.desconectar();
                }
                else
                {
                    usuarioTextBox.Text = senha.Rows[0]["usuarioLogin"].ToString();
                    senhaTextBox.Text = senha.Rows[0]["usuarioSenha"].ToString();
                    checkBox.Checked = true;
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.desconectar();
            }

        }

        private void SalvarLogin()
        {
            Conexao c = new Conexao();

            if (checkBox.Checked)
            {

                try
                {
                    c.conectar();
                    string sql =
                        "UPDATE Contas SET usuarioConectado = null where usuarioConectado = 1;" +
                        "UPDATE Contas SET usuarioConectado = 1 where usuarioLogin = '" + usuarioTextBox.Text + "';";
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
            else
            {
                try
                {
                    c.conectar();
                    string sql =
                        "UPDATE Contas SET usuarioConectado = null where usuarioConectado = 1;";
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

        }



        private void FazerLogin(object sender, EventArgs e)
        {

            if (VerificarUsuario())
            {
                if (VerificarSenha())
                {
                    HomeForm h = new HomeForm(usuarioTextBox.Text, ObterUsuarioId());

                    SalvarLogin();
                    this.Hide();
                    h.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("A senha está incorreta, tente novamente", "Informações incorretas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("O usuário está incorreto, tente novamente", "Informações incorretas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CriarConta(object sender, EventArgs e)
        {
            CadastroForm f = new CadastroForm();
            this.Hide();
            f.ShowDialog();

            if (f.Registrou)
            {
                usuarioTextBox.Text = f.Usuario;
                senhaTextBox.Text = f.Senha;
                checkBox.Checked = false;
            }
            f.Close();
            this.Show();
        }


        private void FechandoJanela(object sender, FormClosingEventArgs e)
        {
            SalvarLogin();
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
        private void AbrirLinkedin(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/caique-araújo-0053201b0/");

        }
    }
}
