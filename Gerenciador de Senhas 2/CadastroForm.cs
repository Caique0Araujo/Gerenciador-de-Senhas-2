﻿using System;
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
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
            this.registrou = false;

        }
        public CadastroForm(int ID)
        {
            InitializeComponent();
            this.registrou = true;
            usuarioID = ID;
            preencherCampos();
        }

        // Três propriedades para preencher os campos no LoginFom caso haja o registro
        public String usuario { get; set; }
        public String senha { get; set; }
        public bool registrou { get; set; }
        private int usuarioID { get; set; }

        // Verifica se o usuário já existe
        private bool verificarUsuario()
        {
            Conexao con = new Conexao();
            try
            {
                con.conectar();

                string sql = "Select usuarioLogin from Contas where usuarioLogin = '" + usuariotextBox.Text + "'";
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
            con.desconectar();
            return false;
        }

        // Verifica os campos TextField

        private bool verificarCampos()
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

        private void preencherCampos()
        {
            Conexao con = new Conexao();
            try
            {
                con.conectar();

                string sql = "Select * from Contas where usuarioID = "+this.usuarioID;
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
            con.desconectar();
        }


        private void cadastroBttn_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao();

            if (registrou && verificarCampos()) {

                try
                {
                    c.conectar();

                    string sql = "UPDATE Contas " +
                        "Set " +
                        "usuarioNome = '" + nometextBox.Text + "' , " +
                        "usuarioLogin = '" + usuariotextBox.Text + "' , " +
                        "usuarioSenha = '" + senhatextBox.Text + "' " +
                        "Where usuarioID = " + this.usuarioID;

                    SQLiteCommand command = new SQLiteCommand(sql, c.con);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Informações salvas com sucesso !", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();


                }catch(Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    c.desconectar();
                }
                c.desconectar();
                registrou = false;


            }

            else if (!registrou && verificarCampos() && verificarUsuario())
            {
                try
                {
                    c.conectar();
                    string sql =
                        "INSERT INTO Contas " +
                        "(usuarioNome, usuarioLogin, usuarioSenha) " +
                        "VALUES " +
                        "('" + nometextBox.Text + "','" + usuariotextBox.Text + "','" + senhatextBox.Text + "')";
                
                    SQLiteCommand command = new SQLiteCommand(sql, c.con);
                    command.ExecuteNonQuery();
                    usuario = usuariotextBox.Text;
                    senha = senhatextBox.Text; 
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
                c.desconectar();
                registrou = true;

            }

        }
    }
}
