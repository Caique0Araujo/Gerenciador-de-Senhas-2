using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace Gerenciador_de_Senhas_2
{
    public partial class CadastroForm : Form
    {

        private const int CS_DropShadow = 0x00020000;

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HTCAPTION = 0x2;



        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);



        public String Usuario;
        public String Senha { get; set; }
        public bool Registrou { get; set; }

        private int usuarioID { get; set; }
        public bool Excluiu { get; set; }



        public CadastroForm()
        {
            InitializeComponent();
            nometextBox.Select();
            this.Registrou = false;
            this.removeButton.Enabled = false;
            this.removeButton.Visible = false;
            this.Excluiu = false;
            label3.Text = "Cadastro";


        }
        public CadastroForm(int ID)
        {
            InitializeComponent();
            this.Registrou = true;
            usuarioID = ID;
            PreencherCampos();
            this.removeButton.Enabled = true;
            this.removeButton.Visible = true;
            this.Excluiu = false;
            label3.Text = "Editar conta";
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



        private bool VerificarUsuario()
        {
            Conexao con = new Conexao();
            try
            {
                con.conectar();

                string sql = "Select usuarioLogin from Contas where usuarioLogin = '" + usuariotextBox.Text + "';";
                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, con.con);
                DataTable usuario = new DataTable();
                dados.Fill(usuario);

                if (usuario.Rows.Count < 1)
                {

                    return true;
                }
                else
                {

                    MessageBox.Show("Já existe uma conta registrada com esse usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
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

        private bool VerificarCampos()
        {
            if (nometextBox.Text == "")
            {
                MessageBox.Show("Insira um nome", "Preenhca os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (usuariotextBox.Text == "")
            {
                MessageBox.Show("Insira um usuário", "Preenhca os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (senhatextBox.Text == "")
            {
                MessageBox.Show("Insira uma senha", "Preenhca os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void PreencherCampos()
        {
            Conexao con = new Conexao();
            try
            {
                con.conectar();

                string sql = "Select * from Contas where usuarioID = " + this.usuarioID + ";";
                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, con.con);
                DataTable senha = new DataTable();
                dados.Fill(senha);


                usuariotextBox.Text = senha.Rows[0]["usuarioLogin"].ToString();
                nometextBox.Text = senha.Rows[0]["usuarioNome"].ToString();
                senhatextBox.Text = senha.Rows[0]["usuarioSenha"].ToString();


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



        private void ConfirmarAcoes(object sender, EventArgs e)
        {
            Conexao c = new Conexao();

            if (Registrou && VerificarCampos())
            {

                try
                {
                    c.conectar();

                    string sql = "UPDATE Contas " +
                        "Set " +
                        "usuarioNome = '" + nometextBox.Text + "' , " +
                        "usuarioLogin = '" + usuariotextBox.Text + "' , " +
                        "usuarioSenha = '" + senhatextBox.Text + "' " +
                        "Where usuarioID = " + this.usuarioID + ";";

                    SQLiteCommand command = new SQLiteCommand(sql, c.con);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Informações salvas com sucesso !", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();


                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    c.desconectar();
                }
                Registrou = false;


            }

            else if (!Registrou && VerificarCampos() && VerificarUsuario())
            {
                try
                {
                    c.conectar();
                    string sql =
                        "INSERT INTO Contas " +
                        "(usuarioNome, usuarioLogin, usuarioSenha) " +
                        "VALUES " +
                        "('" + nometextBox.Text + "','" + usuariotextBox.Text + "','" + senhatextBox.Text + "');";

                    SQLiteCommand command = new SQLiteCommand(sql, c.con);
                    command.ExecuteNonQuery();
                    Usuario = usuariotextBox.Text;
                    Senha = senhatextBox.Text;
                    MessageBox.Show("Usuário cadastrado com sucesso !", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    c.desconectar();
                }
                Registrou = true;

            }

        }

        private void ExcluirConta(object sender, EventArgs e)
        {
            Conexao c = new Conexao();

            try
            {

                if (MessageBox.Show("Deseja excluir a conta atual ?", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    c.conectar();
                    string sql = "delete from Contas where usuarioID = " + usuarioID + "; " +
                                    "delete from Senhas where senhaUsuario = " + usuarioID + "; ";
                    SQLiteCommand command = new SQLiteCommand(sql, c.con);
                    command.ExecuteNonQuery();
                    usuariotextBox.Text = "";
                    senhatextBox.Text = "";
                    nometextBox.Text = "";
                    this.Excluiu = true;
                    this.Dispose();
                    this.Hide();
                    this.Close();
                }

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



        private void MinimizarJanela(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FecharJanela(object sender, EventArgs e)
        {
            Close();
        }

        private void ArrastarJanela(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

    }
}
