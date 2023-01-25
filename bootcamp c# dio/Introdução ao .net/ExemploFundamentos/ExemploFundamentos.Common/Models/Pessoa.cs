using System;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa fisica
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; } //atributos
        public int Idade { get; set; }

        public void Apresentar() //método
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e duro tenho {Idade} anos"); //parametro ou argumento
        }
    }
}