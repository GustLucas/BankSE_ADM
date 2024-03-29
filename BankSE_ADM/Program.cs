﻿using BankSE_ADM.Funcionarios;
using BankSE_ADM.Parceria;
using BankSE_ADM.SistemaInterno;
using BankSE_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("1234522-0", 2000.0);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.Cpf);
//Console.WriteLine(pedro.Salario);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("921389-1");
//roberta.Nome = "Robertinha";



//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.Cpf);
//Console.WriteLine(roberta.Salario);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);
//Console.WriteLine("Total de bonificações:"+ gerenciador.TotalBonificacao);

//Console.WriteLine("Total de funcionarios:"+ Funcionario.TotalFuncionarios);

//pedro.AumentaSalario();
//roberta.AumentaSalario();

//Console.WriteLine("novo salario pedro:" + pedro.Salario);
//Console.WriteLine("novo salario roberta:" + roberta.Salario);
#endregion

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer jorge = new Designer("55112233");
    jorge.Nome = "Jorge Ben Jor";

    Diretor almir = new Diretor("44332211");
    almir.Nome = "Almir Guineto";

    Auxiliar bezerra = new Auxiliar("2931834");
    bezerra.Nome = "Bezerra da Silva";

    GerenteContas arlindo = new GerenteContas("21321122");
    arlindo.Nome = "Arlindo Cruz";

    gerenciador.Registrar(jorge);
    gerenciador.Registrar(almir);
    gerenciador.Registrar(bezerra);
    gerenciador.Registrar(arlindo);

    Console.WriteLine("Total de funcionarios: " + Funcionario.TotalFuncionarios);
    Console.WriteLine("Total de Bonificação: " + gerenciador.TotalBonificacao);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("34244321");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteContas ursula = new GerenteContas("34343432");
    ursula.Nome = "Ursula Acantara";
    ursula.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "666";


    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "943");
    sistema.Logar(caio, "666");


}