using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("99999-9999", "N95", "A0988-5823", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Twitch");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iPhone = new Iphone("8888-88889", "X", "A0888-8888", 64);
iPhone.Ligar();
iPhone.InstalarAplicativo("Netflix");