// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
<<<<<<< HEAD
using System.Linq;
=======
using System.Text.RegularExpressions;

>>>>>>> caceed3535d73b6e29caa8887ec614e1e0fa1958
string name = "";

do {
    Console.WriteLine("Qual é o seu nome?");

<<<<<<< HEAD
name = Console.ReadLine() !;

if (string.IsNullOrWhiteSpace (name))
{
Console.WriteLine("Você digitou um valor inválido, favor digite novamente");
 name = Console.ReadLine() !;  
=======
    name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace (name))
    {
        Console.WriteLine("Você digitou um valor inválido, favor digite novamente");
        name = Console.ReadLine();  
    }
    else if (!Regex.IsMatch(name, @"^[A-Za-z]+$"))
        Console.WriteLine("Não pode conter números.Digite novamente");
>>>>>>> caceed3535d73b6e29caa8887ec614e1e0fa1958
}
while (string.IsNullOrWhiteSpace(name)|| !Regex.IsMatch(name, @"^[A-Za-z]+$"));

<<<<<<< HEAD
else if (name.Any(char.IsDigit))
{Console.WriteLine("Não pode conter números.Digite novamente");
}
}
while (string.IsNullOrWhiteSpace(name)|| name.Any(char.IsDigit));

Console.WriteLine("Seja bem vindo: " +name);


int idade = 0;

do{

Console.WriteLine("Qual sua idade?");

if(!int.TryParse(Console.ReadLine(), out idade))
{Console.WriteLine("Digite apenas números");}}
while (idade == 0) ;



if (idade >= 18) {Console.WriteLine("Você tem " +idade +" anos de idade.");
Console.WriteLine("acesso liberado"); }
else
{  Console.WriteLine("Você é menor que 18, ACESSO NEGADO!!");
}
=======
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
>>>>>>> caceed3535d73b6e29caa8887ec614e1e0fa1958

