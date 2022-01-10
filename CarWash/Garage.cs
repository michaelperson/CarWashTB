using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash
{
    public class Garage
    {
        public event EventHandler SendInfo;
        private Voiture v;
        public Garage(Voiture voiture)
        {
            v = voiture;
        }
        public void VoiturePrete()
        {
            if(SendInfo != null)
            {
                SendInfo(this, new VoitureArgs($"Votre voiture {v.Plaque} est prête"));
            }
        }
    }
}
