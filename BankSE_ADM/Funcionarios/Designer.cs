using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSE_ADM.Funcionarios
{
    public class Designer:Funcionario
    {
        public Designer(string cpf):base(cpf, 3000)
        {
            Console.WriteLine("Criando um Designer...");
        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }
        public override void AumentaSalario()
        {
            this.Salario *= 1.11; // aumenta o salario em 15%
        }
    }
}
