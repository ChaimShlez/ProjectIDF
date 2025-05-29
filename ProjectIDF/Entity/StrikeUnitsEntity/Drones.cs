using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;
using ProjectIDF.Enums;

namespace ProjectIDF.Entity.StrikeUnitsEntity
{
    internal class Drones : AttackUnits ,IBatteryUnit
    {

        private int _Battery = 100 ;
        // constructor
        public Drones(string uniqueName, int ammunitionCapacity, float bombSize, List<TerroristLocation> typeOfTarget)
            : base(uniqueName, ammunitionCapacity, bombSize, typeOfTarget)
        {
        }

       

        public override void MakingAttack()
        {

            MyAmmunitionCapacity --;
        }


        public override void Accept(IUnitVisitor visitor)
        {
            visitor.VisitDrones(this);
        }

        public int Battery
        {
            get { return _Battery; }
            
        }

        public void Recharge()
        {
            if (_Battery == 0){
                _Battery = 100;
            }
            else
            {
                _Battery = 100;
            }
        }


        public override string ToString()
        {

            return $"Unit Name: {MyUniqueName}, Capacity: {MyAmmunitionCapacity}, Bomb Size: {MyBombSize}, Targets: {String.Join(", ", MyTypeOfTarget)},  Battery :  {_Battery}";
        }

    }
}
