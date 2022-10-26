using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"1234-5678", imei:  "000004444", modelo: "Nokia Modelo 2", memoria : 32);

nokia.Ligar();

Console.WriteLine("Digite o aplicativo que você deseja instalar: ");
nokia.InstalarAplicativo(Console.ReadLine());

Console.WriteLine("-------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"0000-5678", imei:  "111104444", modelo: "Iphone Max", memoria : 64);

iphone.Ligar();

Console.WriteLine("Digite o aplicativo que você deseja instalar: ");
iphone.InstalarAplicativo(Console.ReadLine());


