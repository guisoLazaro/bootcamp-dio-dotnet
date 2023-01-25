namespace Models
{
    public class Aluno : Pessoa //herdando da classe pessoa
    {

        public Aluno(string nome) : base(nome) //construtor obrigatório na herança decla-se dessa maneira
        {

        }
        public double Nota { get; set; }

        public override void Apresentar() //polimorfismo do método apresentar da classe pessoa
        {
            Console.WriteLine();
        }
    }
}