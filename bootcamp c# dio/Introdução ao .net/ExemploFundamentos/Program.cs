using ExemploFundamentos.Models; //pasta/namespace aonde está a classe

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

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;

if (quantidadeEmEstoque >= quantidadeCompra) 
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}


//else if(condicao){} -> if aninhado