using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: \n");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("========================================================");

Console.WriteLine("Smartphone Iphone: \n");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
Console.WriteLine("\n");