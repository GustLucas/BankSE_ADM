using BankSE_ADM.Funcionarios;
using BankSE_ADM.Utilitario;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazartes";
pedro.Cpf = "1234522-0";
pedro.Salario = 2000.0;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.Cpf);
Console.WriteLine(pedro.Salario);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Nome = "Robertinha";
roberta.Cpf = "921389-1";
roberta.Salario = 5000.0;


Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.Cpf);
Console.WriteLine(roberta.Salario);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);
Console.WriteLine("Total de bonificações:"+ gerenciador.TotalBonificacao);