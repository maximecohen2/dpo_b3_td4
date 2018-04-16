using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern_Decorator
{
    class Program
    {
        static void Main()
        {
            Modele twingo = new ModeleBase();
            twingo = new ModeleAvecOptionJanteAlu(twingo);
            twingo = new ModeleAvecOptionBasse(twingo);
            twingo = new ModeleAvecOptionPeintureMetal(twingo);

            Modele clio = new ModeleBase();
            clio = new ModeleAvecOptionToitOuvrant(clio);
            clio = new ModeleAvecOptionBasse(clio);
            clio = new ModeleAvecOptionPeintureMetal(clio);

            Console.WriteLine("Le prix de la Clio 3 avec les options Jantes Alu, Basses 500W et Peinture métallique est de : " + clio.Prix + " €");
            Console.WriteLine("Le prix de la Twingo 3 avec les options Toit ouvrant, Basses 500W et Peinture métallique est de : " + twingo.Prix + " €");
        }
    }
}
