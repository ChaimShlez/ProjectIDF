using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;
using ProjectIDF.Enums;

namespace ProjectIDF.Entity.StrikeUnitsEntity
{
    internal class F16Plane : AttackUnits , IFuelUnit

    {

        private int _Fuel = 100;
        // constructor
        public F16Plane(string uniqueName, int ammunitionCapacity, float bombSize, List<TerroristLocation> typeOfTarget)
            : base(uniqueName, ammunitionCapacity, bombSize, typeOfTarget)
        {
        }



       
        public override void MakingAttack()
        {

            MyAmmunitionCapacity  --;
        }

        public override void Accept(IUnitVisitor visitor)
        {
            visitor.VisitF16Plane(this);
        }
        public int Fuel
        {
            get { return _Fuel; }

        }

        public void Refuel()
        {
            if (_Fuel == 0)
            {
                _Fuel = 100;
            }
            else
            {
                _Fuel -= 20;
            }
        }

        public override string ToString()
        {
           
            return $"Unit Name: {MyUniqueName}, Capacity: {MyAmmunitionCapacity}, Bomb Size: {MyBombSize}, " +
                $"Targets: {String.Join(", ", MyTypeOfTarget)}  ,Fuel :  {_Fuel}";

            Console.WriteLine("----------------");
        }
    }
}
