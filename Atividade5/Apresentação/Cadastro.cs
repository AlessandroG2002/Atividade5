using Atividade5.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5.Apresentação
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfSenha.Text)
            {
                Controle controle = new Controle();
                controle.cadastrar(txtLogin.Text, txtSenha.Text, txtConfSenha.Text);
                if (controle.mensagem.Equals(""))
                {
                    if (!controle.encontrado)
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso", "Retornando a Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário já existe", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }
            }
            else
            {
                MessageBox.Show("Senhas informadas não são iguais", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
