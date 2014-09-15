using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStateEngine
{
    public class GeoStatus : GeoStateEngine.IGeoStatus
    {
        public Gem GetGem(Coordinate coordinate)
        {
           return new Gem();

        }
    }

    

}
