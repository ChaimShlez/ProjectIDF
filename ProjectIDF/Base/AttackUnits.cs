using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Enums;

namespace ProjectIDF.Base
{
    abstract class AttackUnits
    {
        // internal
        private string UniqueName;
        private int AmmunitionCapacity;
        private float BombSize;
        private List <TerroristLocation> TypeOfTarget;

        // constructor
        protected AttackUnits(string uniqueName, int ammunitionCapacity, float bombSize, List<TerroristLocation> typeOfTarget)
        {
            this.UniqueName = uniqueName;
            this.AmmunitionCapacity = ammunitionCapacity;
            this.BombSize = bombSize;
            this.TypeOfTarget = typeOfTarget;
            
        }

        public string MyUniqueName
        {
            get { return this.UniqueName; }
            set { this.UniqueName = value; }
        }

        public int MyAmmunitionCapacity
        {
            get { return this.AmmunitionCapacity; }
            set { this.AmmunitionCapacity = value; }
        }

        public float MyBombSize
        {
            get { return this.BombSize; }
            set { this.BombSize = value; }
        }

        public List<TerroristLocation> MyTypeOfTarget
        {
            get { return this.TypeOfTarget; }
            set { this.TypeOfTarget = value; }
        }

        public override string ToString()
        {

            return $"Unit Name: {MyUniqueName},Capacity: {MyAmmunitionCapacity}, Bomb Size: {MyBombSize}, Targets: {String.Join(", ", MyTypeOfTarget)}";
        }

        public abstract void MakingAttack();
    }
}
