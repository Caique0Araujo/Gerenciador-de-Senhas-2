namespace Gerenciador_de_Senhas_2
{
    partial class CadastroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.senhatextBox = new System.Windows.Forms.TextBox();
            this.usuariotextBox = new System.Windows.Forms.TextBox();
            this.nometextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.removeButton = new System.Windows.Forms.Button();
            this.cadastroBttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuário:";
            // 
            // senhatextBox
            // 
            this.senhatextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.senhatextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhatextBox.Location = new System.Drawing.Point(121, 223);
            this.senhatextBox.Name = "senhatextBox";
            this.senhatextBox.Size = new System.Drawing.Size(143, 22);
            this.senhatextBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.senhatextBox, "Senha da conta.");
            // 
            // usuariotextBox
            // 
            this.usuariotextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuariotextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariotextBox.Location = new System.Drawing.Point(120, 184);
            this.usuariotextBox.Name = "usuariotextBox";
            this.usuariotextBox.Size = new System.Drawing.Size(144, 22);
            this.usuariotextBox.TabIndex = 1;
            this.toolTip.SetToolTip(this.usuariotextBox, "Usuário para fazer o login.");
            // 
            // nometextBox
            // 
            this.nometextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nometextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nometextBox.Location = new System.Drawing.Point(119, 142);
            this.nometextBox.Name = "nometextBox";
            this.nometextBox.Size = new System.Drawing.Size(144, 22);
            this.nometextBox.TabIndex = 0;
            this.toolTip.SetToolTip(this.nometextBox, "Nome do usuário.");
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.DimGray;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.Transparent;
            this.removeButton.Location = new System.Drawing.Point(160, 283);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(81, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Excluir";
            this.toolTip.SetToolTip(this.removeButton, "Excluir conta");
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.ExcluirConta);
            // 
            // cadastroBttn
            // 
            this.cadastroBttn.BackColor = System.Drawing.Color.LightGray;
            this.cadastroBttn.FlatAppearance.BorderSize = 0;
            this.cadastroBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastroBttn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroBttn.ForeColor = System.Drawing.Color.Black;
            this.cadastroBttn.Location = new System.Drawing.Point(247, 283);
            this.cadastroBttn.Name = "cadastroBttn";
            this.cadastroBttn.Size = new System.Drawing.Size(81, 23);
            this.cadastroBttn.TabIndex = 3;
            this.cadastroBttn.Text = "Confirmar";
            this.toolTip.SetToolTip(this.cadastroBttn, "Cadastrar um novo usuário.");
            this.cadastroBttn.UseVisualStyleBackColor = false;
            this.cadastroBttn.Click += new System.EventHandler(this.ConfirmarAcoes);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 123);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarJanela);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_minimize_black_24dp;
            this.minimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeButton.Location = new System.Drawing.Point(281, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 24);
            this.minimizeButton.TabIndex = 10;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizarJanela);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_close_black_24dp;
            this.closeButton.Location = new System.Drawing.Point(311, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 20;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.FecharJanela);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(116, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 1000;
            this.label3.Text = "Cadastro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.baseline_account_circle_black_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(62, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nometextBox);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 318);
            this.panel2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(59, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nome:";
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(340, 318);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.cadastroBttn);
            this.Controls.Add(this.senhatextBox);
            this.Controls.Add(this.usuariotextBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senhatextBox;
        private System.Windows.Forms.TextBox usuariotextBox;
        private System.Windows.Forms.TextBox nometextBox;
        private System.Windows.Forms.Button cadastroBttn;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}