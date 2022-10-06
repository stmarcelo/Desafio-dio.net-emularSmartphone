using DesafioPOO.Models;

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "11933221100", modelo: "Modelo I2", imei: "0987654321", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11900112233", modelo: "Modelo A1", imei: "1234567890", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da cobrinha");
