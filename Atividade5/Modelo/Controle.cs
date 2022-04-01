using Atividade5.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5.Modelo
{   public class Controle
    {
        public bool encontrado;
        public String mensagem = "";
        LoginDao loginDao = new LoginDao();

        public bool acessar(String login, String senha)
        {
            encontrado = loginDao.verificarLogin(login, senha);

            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }

            return encontrado;
        }

        public bool cadastrar(String login, String senha, String confirmarSenha)
        {
            encontrado = loginDao.cadastrar(login, senha, confirmarSenha);

            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }

            return encontrado;
        }
    }
}
