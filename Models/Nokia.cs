using System.ComponentModel;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, int memoria) : base(numero, imei, memoria){}
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Baixando... {nomeApp} no Celular NOKIA");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}