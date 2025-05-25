using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;
using ProjectIDF.Enums;

namespace ProjectIDF.Entity.StrikeUnitsEntity
{
    internal class Drones : AttackUnits
    {
        // constructor
        public Drones(string uniqueName, int ammunitionCapacity, float bombSize, List<TerroristLocation> typeOfTarget)
            : base(uniqueName, ammunitionCapacity, bombSize, typeOfTarget)
        {
        }



        public override void MakingAttack()
        {

            MyAmmunitionCapacity = -1;
        }
    }
}
