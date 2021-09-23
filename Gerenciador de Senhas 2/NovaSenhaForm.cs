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

namespace Gerenciador_de_Senhas_2
{
    public partial class NovaSenhaForm : Form
    {

        private int indesOfRow {  get; set; }

        private int escolha {  get; set; }
        
        private int idUser { get; set; }    

        public NovaSenhaForm(int indexOfRow, int idUser, string nome, string link, string senha)
        {
            InitializeComponent();
            this.indesOfRow = indexOfRow;
            this.idUser = idUser;
            label4.Text = "Editar";

            this.escolha = 2;

            nomeTextBox.Text = nome;
            linkTextBox.Text = link;
            senhaTextBox.Text = senha;

        }

        public NovaSenhaForm(int idUser)
        {
            InitializeComponent();
            label4.Text = "Novo";
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
                        "('" + nomeTextBox.Text + "','" + senhaTextBox.Text + "'," + this.idUser + ",'" + linkTextBox.Text + "')";

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
                c.desconectar();

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
                c.desconectar();
                this.Hide();
            }
        }
    }
}
