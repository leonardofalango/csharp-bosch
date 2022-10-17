// See https://aka.ms/new-console-template for more information

Pessoa pessoa = new Pessoa("leonardo", 012345678);
Console.WriteLine(pessoa.Nome);
pessoa.Nome = "falango";
Console.WriteLine(pessoa.Nome);

Console.WriteLine(pessoa.getCPF());