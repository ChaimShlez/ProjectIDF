using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;
using ProjectIDF.UI;


namespace ProjectIDF.Logic.IntelligenceAnalysis
{
    internal class AttackAvailability
    {
        

        public List <AttackUnits> ReadyAttack(List<AttackUnits> units)
        {
           
            
            List<AttackUnits> unitsList = new List<AttackUnits>();
            foreach (AttackUnits unit in units)
            {
                if (unit.MyAmmunitionCapacity > 0)
                {
                   
                    unitsList.Add(unit);
                }
            }
            Console.WriteLine(unitsList.Count);
            
            return unitsList;
        }
    }
}