namespace InversaoDependencia_D
{
    public class Interruptor 
    {
        //privata somente para leitura criada a partir dessa variavel criada como dispositivo 
        private readonly IDispositivo dispositvo;
        private ArCondicionado ar;

//jeito errado
         public Interruptor()
         {
             ar = new ArCondicionado();
         }

//jeito correto
        public Interruptor(IDispositivo dispositivo) // _dispositivo
        {
            //this.dispositivo para nao confundir as variaveis
            this.dispositvo = dispositivo;
        }

        //public void Acionar() => dispositivo.Ligar();

//jeito errado
         public void Acionar()
         {
             ar.Ligar();
         }
    }
}