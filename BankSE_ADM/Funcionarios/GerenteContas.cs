using BankSE_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSE_ADM.Funcionarios
{
    public class GerenteContas:Autenticavel
    {

        public GerenteContas(string cpf):base(cpf, 4000)
        {
            Console.WriteLine("Criando um Gerente de contas...");
        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
        public override void AumentaSalario()
        {
            this.Salario *= 1.05; // aumenta o salario em 15%
        }
        public override bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
