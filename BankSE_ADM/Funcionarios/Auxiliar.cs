using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSE_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf):base(cpf, 2000)
        {
            Console.WriteLine("Criando um Auxiliar...");
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.20; //base acessa o metodo da superclasse ou classe base
        }
        public override void AumentaSalario()
        {
            this.Salario *= 1.10; // aumenta o salario em 15%
        }
    }
}
