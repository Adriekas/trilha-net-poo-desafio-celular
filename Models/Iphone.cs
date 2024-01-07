 namespace DesafioPOO.Models
 {
     // TODO: Herdar da classe "Smartphone"
     public class Iphone : Smartphone //Herança com a Clase Smartphone
     {

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone.");
        }
         //IMPLEMENTADO
     }
}