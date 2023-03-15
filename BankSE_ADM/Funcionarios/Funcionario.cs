using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSE_ADM.Funcionarios
{
    //Funcionario é uma classe abstrata, usada apenas como
    //modelo para outras classes
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; } //protected permite que o Salario seja acessado em sua propria class
                                                     // e nas classes filhas
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        //o metodo com abstract é obrigatório nas classes derivadas.
        public abstract double GetBonificacao();

        public abstract void AumentaSalario();
    }
}
