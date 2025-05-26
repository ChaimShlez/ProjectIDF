using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;
using ProjectIDF.UI;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectIDF.Logic.IntelligenceAnalysis
{
    internal class AttackAvailability
    {
        

        public void ReadyAttack(List<AttackUnits> units)
        {
           

            List<AttackUnits> unitsList = new List<AttackUnits>();
            foreach (AttackUnits unit in units)
            {
                if (unit.MyAmmunitionCapacity > 0)
                {
                   
                    unitsList.Add(unit);
                }
            }
            foreach (AttackUnits unit in unitsList)
            {

               
                string data= ($"Unit Name: {unit.MyUniqueName}," +
                    $" Ammunition Capacity: {unit.MyAmmunitionCapacity}, Bomb Size: {unit.MyBombSize} target :{String.Join(" ", unit.MyTypeOfTarget)}");
                PrintSelection.PrintData(data);
            }
        }
    }
}