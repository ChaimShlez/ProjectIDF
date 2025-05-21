using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;

namespace ProjectIDF.IDF.StrikeUnits
{
    internal class F16Plane : AttackUnits
    {
        // constructor
        public F16Plane(string uniqueName, int ammunitionCapacity, float bombSize, List<string> typeOfTarget)
            : base(uniqueName, ammunitionCapacity, bombSize, typeOfTarget)
        {
        }
    }
}
