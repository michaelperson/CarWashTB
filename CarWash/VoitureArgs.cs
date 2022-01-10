using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash
{
    public class VoitureArgs : EventArgs
    {
        private string _info;

        public string Info { get => _info;  }

        public VoitureArgs(string info)
        {
            this._info = info;
        }
    }
}
