using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EprovAlvaCarlbringDel2
{
    class Car
    {
        public int passenger = 0;
        public int contrabandAmount = 0;
        public bool alreadyChecked = false;
        public static Random generator = new Random();
        public bool contraband = false;


        //borde fungera
        // det ska ialla fall kontrollera ifall man har kontraband eller ej 
          public bool Examine()
          {
            if (contrabandAmount == 0)
            {
                contraband = false;
            }
            if (contrabandAmount != 0)
            {
                contraband = true;
            }

            return contraband;
          }
        

    }
}
