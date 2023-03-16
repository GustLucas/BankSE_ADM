using BankSE_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSE_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if(usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }
        } 
        //sobrecarga no metodo para que receba 2 tipos de funcionarios
    }
}
