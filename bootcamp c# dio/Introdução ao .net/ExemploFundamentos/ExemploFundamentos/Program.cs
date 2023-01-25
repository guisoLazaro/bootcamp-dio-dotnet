using ExemploFundamentos.Common.Models; //pasta/namespace aonde está a classe
using System;


List<string> listaString = new List<string>(); //declaração de uma lista


listaString.Add("SP"); //adiciona itens na lista
listaString.Add("BA");
listaString.Add("MG");

for(int contador = 0; contador < listaString.Count; contador++) //percorre a lista
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

foreach(string item in listaString) //percorre a lista
{
    Console.WriteLine($"{item}");
}

















































//declaração array:

//int[] arrayInteiros = new int[3];

//atribuindo valores nas posições:
//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;







//int[] arrayInteirosDourado = new int[arrayInteiros.Length * 2]; //declaração de um novo array, com o dobro da capacidade do primeiro
//Array.Copy(arrayInteiros, arrayInteirosDourado, 3); //copia o conteudo de um array para outro, com a quantidade total do outro.

//percorrer elementos:

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // -> aumenta a posição do array em execução



// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }

// //percorrendo o array com o forech - joga o valor de cada posição do array para a variavel declarada
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }















//Pessoa pessoa1 = new Pessoa();







































// string opcao;
// bool exibirMenu = true;

// while(true)
// {
//     Console.Clear(); //limpa o menu
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");
//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;      //Environment.Exit(0); //sai do programa
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;

//     }
// }



























// Calculadora calc = new Calculadora();
// calc.Somar(10, 30);















/*string apresentacao = "Olá, seja bem vindo"; //declaração de variavel 
int quantidade = 1; //declaração de variavel
double altura = 1.80;
decimal preco = 1.80M; //colocar m no final do tipo decimal

bool condicao = true;
*/


// Pessoa p = new Pessoa();

// p.Nome = "Gui";
// p.Idade = 31;
// p.Apresentar();

/*int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;

if (quantidadeEmEstoque >= quantidadeCompra) 
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
} */


//else if(condicao){} -> if aninhado