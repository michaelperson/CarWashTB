// See https://aka.ms/new-console-template for more information
using CarWash;

Console.WriteLine("CarWash");

//1 INstancier une voiture

Voiture Lada = new Voiture("1-RFG-256");

//2 Instancier ma classe de lavage

LaveVoiture laveVoiture = new LaveVoiture( LaveVoiture.Programme.basic);

//3 Appeller les méthodes
//laveVoiture.Laver(Lada);
//laveVoiture.Preparer(Lada);
//laveVoiture.Finaliser(Lada);
//laveVoiture.Secher(Lada);

//Pour éviter l'appel dans un ordre barbare ==> Private les méthodes de la classe laveVoiture

//laveVoiture.Traiter(Lada); ==> Remplacer l'appel de la méthode par l'appel au délégué

//laveVoiture.LaveLaCaisse(Lada); ==> le délégué est passé en privé

laveVoiture.Traiter(Lada);

//1 INstancier une voiture

Voiture Renault = new Voiture("1-RFG-8556"); 

LaveVoiture laveVoiture2 = new LaveVoiture(LaveVoiture.Programme.intermediaire); 

laveVoiture2.Traiter(Renault);

Voiture Mercedes = new Voiture("1-BestDev");

LaveVoiture laveVoiture3 = new LaveVoiture(LaveVoiture.Programme.VIP);

laveVoiture3.Traiter(Mercedes);
