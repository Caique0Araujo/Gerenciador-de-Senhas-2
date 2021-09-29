using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace Gerenciador_de_Senhas_2
{
    public partial class NovaSenhaForm : Form
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
        private int indesOfRow {  get; set; }

        private int escolha {  get; set; }
        
        private int idUser { get; set; }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        public NovaSenhaForm(int indexOfRow, int idUser, string nome, string link, string senha)
        {
            InitializeComponent();
            this.indesOfRow = indexOfRow;
            this.idUser = idUser;
            label4.Text = "Editar Senha";
            label5.Text = "Editar";

            this.escolha = 2;

            nomeTextBox.Text = nome;
            linkTextBox.Text = link;
            senhaTextBox.Text = senha;

        }

        public NovaSenhaForm(int idUser)
        {
            InitializeComponent();
            label4.Text = "Nova Senha";
            label5.Text = "Nova";
            this.escolha = 1;
            this.idUser = idUser;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao();

            if (nomeTextBox.Text == "")
            {
                MessageBox.Show("Insira um nome", "Preenhca os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (senhaTextBox.Text == "")
            {
                MessageBox.Show("Insira uma senha", "Preenhca os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (linkTextBox.Text == "")
            {
                MessageBox.Show("Insira um link", "Preenhca os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (escolha == 1) //add
            {
                try
                {

                    c.conectar();
                    string sql =
                        "INSERT INTO Senhas " +
                        "(senhaNome, senhaSenha, senhaUsuario, senhaLink) " +
                        "VALUES " +
                        "('" + nomeTextBox.Text + "','" + senhaTextBox.Text + "'," + this.idUser + ",'" + linkTextBox.Text + "');";

                    SQLiteCommand command = new SQLiteCommand(sql, c.con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Senha registrada com sucesso !", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    c.desconectar();
                }

                this.Hide();

            }
            else if (escolha == 2) // edit
            {
                try
                {
                    c.conectar();
                    string sql =
                        "UPDATE Senhas  " +
                        "SET " +
                        "senhaNome = '" + nomeTextBox.Text +"'," +
                        "senhaSenha = '"+senhaTextBox.Text+"'," +
                        "senhaLink = '"+linkTextBox.Text+"'" +
                        "WHERE senhaID = "+indesOfRow+"; ";

                    SQLiteCommand command = new SQLiteCommand(sql, c.con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados alterados com sucesso !", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    c.desconectar();
                }
                this.Hide();
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
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
