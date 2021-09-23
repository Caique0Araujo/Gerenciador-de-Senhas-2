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
            this.label4 = new System.Windows.Forms.Label();
            this.nometextBox = new System.Windows.Forms.TextBox();
            this.cadastroBttn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuário:";
            // 
            // senhatextBox
            // 
            this.senhatextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.senhatextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhatextBox.Location = new System.Drawing.Point(60, 112);
            this.senhatextBox.Name = "senhatextBox";
            this.senhatextBox.Size = new System.Drawing.Size(152, 22);
            this.senhatextBox.TabIndex = 3;
            this.toolTip.SetToolTip(this.senhatextBox, "Senha da conta.");
            // 
            // usuariotextBox
            // 
            this.usuariotextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuariotextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariotextBox.Location = new System.Drawing.Point(68, 73);
            this.usuariotextBox.Name = "usuariotextBox";
            this.usuariotextBox.Size = new System.Drawing.Size(144, 22);
            this.usuariotextBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.usuariotextBox, "Usuário para fazer o login.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome:";
            // 
            // nometextBox
            // 
            this.nometextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nometextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nometextBox.Location = new System.Drawing.Point(60, 32);
            this.nometextBox.Name = "nometextBox";
            this.nometextBox.Size = new System.Drawing.Size(152, 22);
            this.nometextBox.TabIndex = 1;
            this.toolTip.SetToolTip(this.nometextBox, "Nome do usuário.");
            // 
            // cadastroBttn
            // 
            this.cadastroBttn.BackColor = System.Drawing.Color.Transparent;
            this.cadastroBttn.FlatAppearance.BorderSize = 0;
            this.cadastroBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastroBttn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroBttn.ForeColor = System.Drawing.Color.Transparent;
            this.cadastroBttn.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.baseline_check_circle_black_36dp;
            this.cadastroBttn.Location = new System.Drawing.Point(102, 146);
            this.cadastroBttn.Name = "cadastroBttn";
            this.cadastroBttn.Size = new System.Drawing.Size(36, 36);
            this.cadastroBttn.TabIndex = 4;
            this.toolTip.SetToolTip(this.cadastroBttn, "Cadastrar um novo usuário.");
            this.cadastroBttn.UseVisualStyleBackColor = false;
            this.cadastroBttn.Click += new System.EventHandler(this.cadastroBttn_Click);
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(233, 194);
            this.Controls.Add(this.cadastroBttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nometextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senhatextBox);
            this.Controls.Add(this.usuariotextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senhatextBox;
        private System.Windows.Forms.TextBox usuariotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nometextBox;
        private System.Windows.Forms.Button cadastroBttn;
        private System.Windows.Forms.ToolTip toolTip;
    }
}