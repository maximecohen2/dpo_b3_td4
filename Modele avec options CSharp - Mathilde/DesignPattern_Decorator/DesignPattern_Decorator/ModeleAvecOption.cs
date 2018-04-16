using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    class ModeleAvecOption : Modele
    {
        protected Modele _initial;
        protected double _prixOption;

        public ModeleAvecOption(Modele initial, double prixOption)
        {
            _initial = initial;
            _prixOption = prixOption;
        }
        public override double Prix
        {
            get { return _initial.Prix + _prixOption; }
        }
    }
}


