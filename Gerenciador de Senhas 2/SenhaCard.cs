using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Senhas_2
{
    public partial class SenhaCard : UserControl
    {
        public SenhaCard()
        {
            InitializeComponent();
            labelSenha.Text = "*****";
            _selected = false;

        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; labelNome.Text = value; }
        }

        private string _link;

        public string Link
        {
            get { return _link; }
            set { _link = value; labelLink.Text = value; }
        }

        private string _senha;

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        private Image _icon;

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox.Image = value; }
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private bool _selected;

        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }


        private void buttonSenha_Click(object sender, EventArgs e)
        {
            if(labelSenha.Text == "*****")
            {
                labelSenha.Text = Senha;
            }else
            {
                labelSenha.Text = "*****";
            }
        }

        private void SenhaCard_Click(object sender, EventArgs e)
        {
            if (_selected)
            {
                _selected = false;
                BackColor = Color.White;
                BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                _selected = true;
                BackColor = Color.LightGray;
                BorderStyle = BorderStyle.Fixed3D;
            }
        }
    }
}
