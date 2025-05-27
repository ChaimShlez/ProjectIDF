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

        public override string ToString()
        {

            return $"Unit Name: {MyUniqueName}, Capacity: {MyAmmunitionCapacity}, Bomb Size: {MyBombSize}, Targets: {String.Join(", ", MyTypeOfTarget)}";
        }

        public override void MakingAttack()
        {

            MyAmmunitionCapacity --;
        }
    }
}
