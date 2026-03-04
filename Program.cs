// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

Console.WriteLine("Qual é o seu nome?");

string name = Console.ReadLine();

Console.WriteLine("Seja bem vindo: " +name);
Console.WriteLine("Qual a sua idade?");
int idade;
int.TryParse(Console.ReadLine(), out idade);
if (idade >= 18) 
{Console.WriteLine("Você tem " +idade +" anos de idade.");
Console.WriteLine("acesso liberado"); }
else
{
    Console.WriteLine("Você é menor que 18, ACESSO NEGADO!!");
}
