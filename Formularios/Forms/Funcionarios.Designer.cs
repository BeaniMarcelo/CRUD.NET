namespace Formularios.Forms
{
    partial class Funcionarios
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.grid_funcionarios = new System.Windows.Forms.DataGridView();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(213, 295);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // grid_funcionarios
            // 
            this.grid_funcionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_funcionarios.Location = new System.Drawing.Point(360, 68);
            this.grid_funcionarios.Name = "grid_funcionarios";
            this.grid_funcionarios.Size = new System.Drawing.Size(521, 335);
            this.grid_funcionarios.TabIndex = 1;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(567, 36);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(154, 20);
            this.txt_pesquisar.TabIndex = 2;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(22, 295);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(115, 295);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(426, 34);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(106, 23);
            this.btn_pesquisar.TabIndex = 5;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(22, 137);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(22, 183);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 7;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(22, 226);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 8;
            this.lbl_endereco.Text = "Endereco";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(115, 134);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(154, 20);
            this.txt_nome.TabIndex = 9;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(115, 176);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(154, 20);
            this.txt_telefone.TabIndex = 10;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(115, 223);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(221, 20);
            this.txt_endereco.TabIndex = 11;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 451);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.grid_funcionarios);
            this.Controls.Add(this.btn_cancelar);
            this.Name = "Funcionarios";
            this.Text = "Cadastro de Funcionarios DAPPER";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView grid_funcionarios;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_endereco;
    }
}