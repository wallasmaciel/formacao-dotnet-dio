namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia(string numero, string modelo, string imei, int memoria) : Smartphone(numero, modelo, imei, memoria)
    {
        public override void InstalarAplicativo(string nomeApp) {
            Console.WriteLine($"Instalando aplicativo \"{nomeApp}\" no Nokia");
        }
    }
}