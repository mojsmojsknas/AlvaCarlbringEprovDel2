using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EprovAlvaCarlbringDel2
{//Subklass till Car
    class ContrabandCar:Car
    {
        //Gör fixar ett random antal kontraband och passagerare 
        public ContrabandCar()
        {
            int cNumber = generator.Next(1,5);
            cNumber = contrabandAmount;
            
            int pNumber = generator.Next(1, 5);
            pNumber = passenger;
        }


    }
}
