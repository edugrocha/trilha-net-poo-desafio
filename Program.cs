using DesafioPOO.Models;

// IMPLEMENTADO

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "81943214321", modelo: "Nokia G60 NK108", imei: "000000000", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(nomeApp: "Spotify");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "81912341234", modelo: "iPhone 13", imei: "111111111", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "YouTube");