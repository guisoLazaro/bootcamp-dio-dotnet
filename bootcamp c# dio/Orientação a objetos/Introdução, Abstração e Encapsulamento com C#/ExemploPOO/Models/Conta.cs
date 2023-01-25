namespace Models
{
    public abstract class Conta //classe abstrata, não pode ser instanciada, só modelo
    {
        protected decimal saldo; //protegido para alterações externas com exceção da suas classe filhas

        public abstract void Creditar(decimal valor); //método abstrato

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }
    }
}