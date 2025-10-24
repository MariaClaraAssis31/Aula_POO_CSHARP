
namespace InversaoDependencias_D
{
    public class Interruptor
    {
        //privada somente leitura, variavel criada como dispositivo
        private readonly IDispositivo dispositivo; 
        private readonly ArCondicionado ar;

        //jeito errado
        public Interruptor()
        {
            ar = new ArCondicionado();
        }    

        //jeito correto 
       // public Interruptor(IDispositivo dispositivo)
        //{
          //  this.dispositivo = dispositivo; //o this e para nao confundir a varivavel, pois elas tem o mesmo nome 
        //}

       // public void Acionar() => dispositivo.Ligar();
        
        //jeito errado
        public void Acionar ()
        {
            ar.Ligar();
        }
    }
}
