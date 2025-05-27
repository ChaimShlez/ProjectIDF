using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;
using ProjectIDF.Entity;

namespace ProjectIDF.Logic.Attacks
{
    internal class StrikeExecution
    {

        public void Execution(AttackUnits unit, ReportEntity report)
        {


           

                //if (unit.MyAmmunitionCapacity > 0 && unit.MyTypeOfTarget.Contains(report.TrreorLocation))
                //{
                //    Console.WriteLine($"Executing strike on {report.ReportTerroist.nameTrrorist} with {unit.MyUniqueName}");
                //    ManegerAttack.MakeManegerAttack(unit);
                //    //Console.WriteLine($"{unit.MyUniqueName} has {unit.MyAmmunitionCapacity} ammunition left");
                //}
                //else
                //{
                //    Console.WriteLine($"{unit.MyUniqueName} is not available for attack or does not match the target type.");
                //}
            }
        }
    }
}