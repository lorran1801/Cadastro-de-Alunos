using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Alunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Codigo = 1;

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string caminho = @"C:\ecosis\arqAluno.txt";

                if (!File.Exists(caminho))
                {

                    File.CreateText(caminho).Dispose();
                }
                else
                {
                    using (StreamWriter arquivo = File.AppendText(caminho))
                    {
                        DTO_Aluno meuAluno = new DTO_Aluno();
                        meuAluno.Codigo = Codigo.ToString();
                        meuAluno.Nome = tb_Aluno.Text;
                        meuAluno.Matricula = tb_Matricula.Text;
                        meuAluno.CPF = tb_CPF.Text;
                        string texto = meuAluno.Codigo + ";" + meuAluno.Nome + ";" + meuAluno.Matricula + ";" + meuAluno.CPF;
                        arquivo.WriteLine(texto);
                        arquivo.Close();
                        MessageBox.Show("Salvo com Sucesso!!!");
                        Codigo++;
                        tb_Codigo.Text = Codigo.ToString();
                        tb_Aluno.Text = string.Empty;
                        tb_Matricula.Text = string.Empty;
                        tb_CPF.Text = string.Empty;
                        Leitura();
                    }
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_Codigo.Text = Codigo.ToString();
            tb_Aluno.Focus();
        }

      

        private void Leitura()
        {
            
            List<DTO_Aluno> dadosLidos = new List<DTO_Aluno>();
            System.IO.StreamReader arquivo = new System.IO.StreamReader(@"C:\ecosis\arqAluno.txt");
            string linha = "";
            while (true)
            {
                linha = arquivo.ReadLine();
                if (linha != null)
                {
                    string[] DadosColetados = linha.Split(';');
                    dadosLidos.Add(new DTO_Aluno { Codigo = DadosColetados[0], Nome = DadosColetados[1], Matricula = DadosColetados[2],CPF = DadosColetados[3] });
                }
                else
                    break;
            }
            
            DG_Dados.DataSource = dadosLidos;
            DG_Dados.Refresh();
            arquivo.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Leitura();
        }

        private void Tb_Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (tb_Pesquisa.Text != "")
            {
                try
                {
                    //DataTable table = new DataTable(DG_Dados)
                    //DataView.RowFilter = "Nome=" + lblCodItem.Text + " and preco=" + txtPreco.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro :" + ex.Message);
                }
            }
            if (tb_Pesquisa.Text == "")
            {
              
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Tb_Matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

