using BankSE_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSE_ADM.Utilitario
{
    public class GerenciadorBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.GetBonificacao();
        } 
    }
}
