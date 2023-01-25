namespace Models
{
    public  class Professor : Pessoa  //
    {
           public Professor(string nome) : base(nome) //construtor obrigatório na herança decla-se dessa maneira
        {

        }
        public decimal Salario { get; set; }
    }
}