// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using System.Text.RegularExpressions;

string name = "";

do {
    Console.WriteLine("Qual é o seu nome?");

    name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace (name))
    {
        Console.WriteLine("Você digitou um valor inválido, favor digite novamente");
        name = Console.ReadLine();  
    }
    else if (!Regex.IsMatch(name, @"^[A-Za-z]+$"))
        Console.WriteLine("Não pode conter números.Digite novamente");
}
while (string.IsNullOrWhiteSpace(name)|| !Regex.IsMatch(name, @"^[A-Za-z]+$"));

Console.WriteLine($"Seja bem vindo: {name}");
Console.WriteLine("Qual a sua idade?");
int idade;
int.TryParse(Console.ReadLine(), out idade);
if (idade > 0 && idade >= 18) 
{
    Console.WriteLine($"Você tem {idade} anos de idade.");
    Console.WriteLine("acesso liberado");
}
else
    Console.WriteLine("Você é menor que 18, ACESSO NEGADO!!");

