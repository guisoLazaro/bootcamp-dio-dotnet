using ExemploFundamentos.Models; //pasta/namespace aonde está a classe

string opcao;
bool exibirMenu = true;

while(true)
{
    Console.Clear(); //limpa o menu
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;      //Environment.Exit(0); //sai do programa
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }
}



























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