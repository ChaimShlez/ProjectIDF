using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;

namespace ProjectIDF.IDF.Attacks
{
    internal class MAnegerAttack
    {
        public void MAneger(List<AttackUnits> units)
        {
            foreach (var unit in units)
            {
                unit.MakingAttack();
            }
        }
    }
}
