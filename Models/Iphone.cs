namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, int memoria) : base(numero, imei, memoria){}
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Baixando... {nomeApp} no Iphone");
        }

    }
}