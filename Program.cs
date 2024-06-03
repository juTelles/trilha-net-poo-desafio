using DesafioPOO.Models;

//Testando nova instancia da classe Iphone e seus metodos
Iphone iphone1 = new Iphone("319986926", "Iphone 14", "009348759384", 500);
iphone1.InformacoesDoDispositivo();
iphone1.ReceberLigacao();
iphone1.Ligar();
iphone1.InstalarAplicativo("GetFit");

Console.WriteLine("\n");

//Testando uma segunda instancia da classe Iphone e seus metodos
Iphone iphone2 = new Iphone("569986926", "Iphone 15", "119348759384", 400);
iphone2.InformacoesDoDispositivo();
iphone2.ReceberLigacao();
iphone2.Ligar();
iphone2.InstalarAplicativo("Iphone Studio");

Console.WriteLine("\n");

//Testando nova instancia da classe Nokia e seus metodos
Nokia nokia1 = new Nokia("199986926", "B5G9", "79348759384", 50);
nokia1.InformacoesDoDispositivo();
nokia1.ReceberLigacao();
nokia1.Ligar();
nokia1.InstalarAplicativo("Google Chrome");

Console.WriteLine("\n");

//Testando uma segunda instancia da classe Nokia e seus metodos
Nokia nokia2 = new Nokia("209954544", "B3", "8934876456", 100);
nokia2.InformacoesDoDispositivo();
nokia2.ReceberLigacao();
nokia2.Ligar();
nokia2.InstalarAplicativo("Nokia Clock");

Console.WriteLine("\n");

// Testando modificacao de numero de um dispositivo
nokia1.Numero = "12-9890843";
nokia1.InformacoesDoDispositivo();
