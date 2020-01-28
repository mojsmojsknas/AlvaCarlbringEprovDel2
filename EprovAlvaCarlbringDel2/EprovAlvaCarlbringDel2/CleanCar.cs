using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EprovAlvaCarlbringDel2
{//Subklass till Car
    class CleanCar:Car
    {
        //fixar ett random antal passagerare
        public CleanCar()
        {
            int pNumber = generator.Next(1, 4);
            pNumber = passenger;

        }



    }
}
