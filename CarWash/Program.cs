// See https://aka.ms/new-console-template for more information
using CarWash;

Console.WriteLine("CarWash");

 

 
LaveVoiture laveVoiture = new LaveVoiture( LaveVoiture.Programme.basic);
//laveVoiture.SendStatus = AfficherStatus;

Voiture Mercedes = new Voiture("1-BestDev");


laveVoiture.Traiter(Mercedes);

//Défi : Faire en sorte de sortir les cw de la classe LaveVoiture pour que ça soit la classe program
// qui se charge d'afficher les messages d'états
// Indice : il faut utiliser un délégué et une fonction créée dans program.cs

static void AfficherStatus(string Message)
{
    Console.WriteLine(Message);
}