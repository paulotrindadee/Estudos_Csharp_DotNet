// // // Atividade 01 :
// // // Declare uma variável pra:
// // // Sua idade
// // // Sua altura
// // // Seu nome
// // // Se você está estudando C# agora

// // using System;

// // class AtividadeRapida

// // {
// // static void Main() 
// // { 
// // int idade = 35;
// // float altura = 1.78f;
// // string nome = "Paulo";
// // bool EstudandoCsharp = true;

// // Console.WriteLine($"Nome:{nome}");
// // Console.WriteLine($"Idade:{idade} anos");
// // Console.WriteLine($"Altura:{altura}");
// // Console.WriteLine($"Estudando C# agora? {EstudandoCsharp}");
// // }
// // }


// //######################################################################

// //Atividade 02


// Escreva um programa que:

// Pergunta a idade do usuário (use Console.ReadLine() e int.Parse)

// Diz se pode ou não tirar carteira de motorista (18+)




using System;

class program
{


static void Main()
{

    Console.Write("Digite a sua idade:  ");
    int idade = int.Parse(Console.ReadLine());

    if (idade >= 18 )
    {
        Console.WriteLine("Você pode tirar a carteira de motorista!");
    }
    
    else 
    {
        Console.WriteLine("Você ainda não pode tirar a carteira de motorista!");
    }

}

}