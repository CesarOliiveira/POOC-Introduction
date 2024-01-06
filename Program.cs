using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone(numero: "2112341312", imei: "1223", memoria: 64);

iphone.InstalarAplicativo("8Ball Pool");
iphone.Ligar("2112341312");
iphone.ReceberLigacao();

Smartphone nokia = new Nokia(numero: "2112341312", imei: "Modelo 3", memoria: 16);

nokia.InstalarAplicativo("Clash Royale");
nokia.Ligar("2112341312");
nokia.ReceberLigacao();
