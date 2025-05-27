using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;
using ProjectIDF.Entity;

namespace ProjectIDF.Logic.Attacks
{
    internal static class ManegerAttack
    {
        public static void MakeAttack(AttackUnits unit, ReportEntity report)
        {
            report.ReportTerroist.statusTrrorist = false;
             unit.MakingAttack();

            Console.WriteLine(unit);
            Console.WriteLine(report);

        }
    }
}
