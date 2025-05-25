using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;

namespace ProjectIDF.Entity.StrikeUnitsEntity
{
    internal class F16Plane : AttackUnits
    {
        // constructor
        public F16Plane(string uniqueName, int ammunitionCapacity, float bombSize, List<string> typeOfTarget)
            : base(uniqueName, ammunitionCapacity, bombSize, typeOfTarget)
        {
        }




        public override void MakingAttack()
        {

            MyAmmunitionCapacity = -1;
        }
    }
}
