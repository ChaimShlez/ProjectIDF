using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;

namespace ProjectIDF.Entity.StrikeUnitsEntity
{
    internal class CollectionUnits
    {
        List<AttackUnits> units;

        public CollectionUnits()
        {
            units = new List<AttackUnits>();
        }

        public List <AttackUnits> MyCollectionUnits
        {
            get { return units; }
            set { units = value; }
        }
    }
}
