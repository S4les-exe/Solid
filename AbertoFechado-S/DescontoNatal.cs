namespace AbertoFechado_S
{
    public class DescontoNatal : Desconto
    {
        public override double Calcular(double valor) => valor * 0.10; 
    }
}