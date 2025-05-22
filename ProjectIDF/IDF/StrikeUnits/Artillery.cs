using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;
using ProjectIDFbase;

namespace ProjectIDF.IDF.StrikeUnits
{
    internal class Artillery : AttackUnits
    {
        // constructor
        public Artillery(string uniqueName, int ammunitionCapacity, float bombSize, List<string> typeOfTarget)
            : base(uniqueName, ammunitionCapacity, bombSize, typeOfTarget)
        {
        }

        public override void MakingAttack()
        {

            MyAmmunitionCapacity = -1;
        }
    }
}
