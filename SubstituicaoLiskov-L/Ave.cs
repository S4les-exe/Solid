namespace SubstituicaoLiskov_L
{
    public abstract class Ave
    {
        public abstract void Mover();

        public virtual void Dormir() => Console.WriteLine("Dormindo...."); 
        //virtual nao te obriga a trazer o void pra todas as classes, deixa uma como padrao 
    }
}