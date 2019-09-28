namespace Cadastro_de_Alunos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.tb_Aluno = new System.Windows.Forms.TextBox();
            this.tb_Matricula = new System.Windows.Forms.TextBox();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DG_Dados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Pesquisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_CPF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Dados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Codigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Codigo.Location = new System.Drawing.Point(38, 131);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(57, 31);
            this.tb_Codigo.TabIndex = 0;
            this.tb_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // tb_Aluno
            // 
            this.tb_Aluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Aluno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aluno.Location = new System.Drawing.Point(101, 131);
            this.tb_Aluno.MaxLength = 50;
            this.tb_Aluno.Name = "tb_Aluno";
            this.tb_Aluno.Size = new System.Drawing.Size(261, 31);
            this.tb_Aluno.TabIndex = 1;
            // 
            // tb_Matricula
            // 
            this.tb_Matricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Matricula.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Matricula.Location = new System.Drawing.Point(368, 131);
            this.tb_Matricula.MaxLength = 4;
            this.tb_Matricula.Name = "tb_Matricula";
            this.tb_Matricula.Size = new System.Drawing.Size(133, 31);
            this.tb_Matricula.TabIndex = 3;
            this.tb_Matricula.TextChanged += new System.EventHandler(this.Tb_Matricula_TextChanged);
            this.tb_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cadastrar.Location = new System.Drawing.Point(643, 129);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(157, 31);
            this.bt_Cadastrar.TabIndex = 4;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.Bt_Cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cód";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matricula";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // DG_Dados
            // 
            this.DG_Dados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DG_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Dados.Location = new System.Drawing.Point(38, 314);
            this.DG_Dados.Name = "DG_Dados";
            this.DG_Dados.Size = new System.Drawing.Size(550, 150);
            this.DG_Dados.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(222, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cadastro de Alunos";
            // 
            // tb_Pesquisa
            // 
            this.tb_Pesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Pesquisa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pesquisa.Location = new System.Drawing.Point(38, 277);
            this.tb_Pesquisa.MaxLength = 50;
            this.tb_Pesquisa.Name = "tb_Pesquisa";
            this.tb_Pesquisa.Size = new System.Drawing.Size(297, 31);
            this.tb_Pesquisa.TabIndex = 1;
            this.tb_Pesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_Pesquisa_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pesquisa";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // tb_CPF
            // 
            this.tb_CPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_CPF.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CPF.Location = new System.Drawing.Point(507, 130);
            this.tb_CPF.MaxLength = 11;
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(133, 31);
            this.tb_CPF.TabIndex = 9;
            this.tb_CPF.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(549, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF";
            this.label6.UseWaitCursor = true;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_CPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DG_Dados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.tb_Matricula);
            this.Controls.Add(this.tb_Pesquisa);
            this.Controls.Add(this.tb_Aluno);
            this.Controls.Add(this.tb_Codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Dados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.TextBox tb_Aluno;
        private System.Windows.Forms.TextBox tb_Matricula;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DG_Dados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Pesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_CPF;
        private System.Windows.Forms.Label label6;
    }
}

