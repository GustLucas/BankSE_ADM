using BankSE_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSE_ADM.Funcionarios
{
    // :Funcionario para dizer que a classe diretor é do tipo funcionario 
    public class Diretor : FuncionarioAutenticavel
    {

        // override para dizer que o metodo é sobrescrito
        public override double GetBonificacao()
        {
            return this.Salario + 0.50; //base acessa o metodo da superclasse ou classe base
        }

        public Diretor(string cpf):base(cpf, 5000)
        {
            Console.WriteLine("Criando um diretor...");
        } //a ordem de criação de metodos sempre vai ser: superclasse -> classe derivada

        public override void AumentaSalario()
        {
            this.Salario *= 1.15; // aumenta o salario em 15%
        }
    }
}
