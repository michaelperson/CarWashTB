using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash
{
    public  class Voiture
    {
        private string _plaque;

        public string Plaque { get => _plaque;  }

        public Voiture(string laPlaque)
        {
            this._plaque = laPlaque;
        }
    }
}
