using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone=new Iphone("3333","pro","1111",5);
iphone.Ligar();
Console.WriteLine($"O {iphone.Modelo} tem {iphone.Memoria}GB de memoria");
iphone.InstalarAplicativo("Zap");
Nokia  nokia=new Nokia("3333","win","1111",32);
nokia.ReceberLigacao();
Console.WriteLine($"O {nokia.Modelo} tem {nokia.Memoria}GB de memoria");



