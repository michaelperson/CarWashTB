using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash
{
    public class LaveVoiture
    {

        public delegate void DelegateAfficherStatus(string Message);
        public DelegateAfficherStatus SendStatus;


        //3.2 Préparation du délégué pour exécuter les méthodes de ma classe
        public delegate void DelegateLavage(Voiture v);
        //3.3 Créer une variable du type du délégué créé en 3.2
        private DelegateLavage LaveLaCaisse;

        private string _message;

        public string Message { get => _message;  }

        public enum Programme
        {
            basic,
            intermediaire,
            VIP
        }

        public LaveVoiture(Programme programmeChoisi)
        {
            switch (programmeChoisi)
            {
                case Programme.basic:
                    LaveLaCaisse += Laver;
                    LaveLaCaisse += Secher;
                    break;
                case Programme.intermediaire:
                    LaveLaCaisse = Preparer;
                    LaveLaCaisse += Laver;
                    LaveLaCaisse += Secher;
                    break;
                case Programme.VIP:
                    //4 Instancier ==> Ajouter les méthodes a exécuter dans le délégué
                    LaveLaCaisse = Preparer;
                    LaveLaCaisse += Laver;
                    LaveLaCaisse += Secher;
                    LaveLaCaisse += Finaliser;
                    break; 
            }

           
        }

        private void Preparer(Voiture v)
        {
            if(SendStatus!=null)
            SendStatus($"Je prépare la voiture {v.Plaque}");
          //this._message = $"Je prépare la voiture {v.Plaque}";
            //Console.WriteLine();
        }
        private void Laver(Voiture v)
        {
            if (SendStatus != null)
                SendStatus($"Je lave la voiture {v.Plaque}");
        }
        private void Secher(Voiture v)
        {
            if (SendStatus != null)
                SendStatus($"Je sèche la voiture {v.Plaque}");
        }
        private void Finaliser (Voiture v)
        {
            if (SendStatus != null)
                SendStatus($"Je finalise la voiture {v.Plaque}");
        }

        public void Traiter(Voiture v)
        {
            if (LaveLaCaisse != null)
            {
                LaveLaCaisse(v);
            }
        }
    }
}
