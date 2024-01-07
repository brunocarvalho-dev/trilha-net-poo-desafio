using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nk = new Nokia("Numero Nokia");
nk.Ligar();
nk.ReceberLigacao();
nk.InstalarAplicativo("Whatsapp");
nk.ModeloSmart("css", "dsr1235fr", 4);
nk.MostrarModelo();

Iphone iphone = new Iphone("Numero Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
iphone.ModeloSmart("abcd", "123456jklm", 8);
iphone.MostrarModelo();
