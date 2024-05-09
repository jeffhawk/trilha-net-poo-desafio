using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "19999999999", modelo: "N100", imei: "12345678901234", memoria: "64" );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "19988888888", modelo: "X", imei: "12345678908974", memoria: "128" );
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");