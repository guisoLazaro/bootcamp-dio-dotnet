namespace Models
{
    public class Pessoa
    {

        public Pessoa(string nome) // construtor que exige passar o nome
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() //virtual - > método pode ser sobrescrito (poliformismo)
        {
            Console.WriteLine($"Olá, meu nome é {Nome}  e tenho {Idade} anos!");
        }
    }
}