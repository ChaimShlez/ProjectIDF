using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Entity;
using ProjectIDF.Enums;
using ProjectIDF.UI;

namespace ProjectIDF.Logic.IntelligenceAnalysis
{
    internal class TargetPrioritization
    {
        public ReportEntity? MostDangerousTerrorist(List<ReportEntity> reports)
        {
            Dictionary<string, List<ReportEntity>> dictReports = new Dictionary<string, List<ReportEntity>>();

            foreach (ReportEntity rep in reports)
            {
                if (!dictReports.ContainsKey(rep.ReportTerroist.nameTrrorist))
                {
                    dictReports[rep.ReportTerroist.nameTrrorist] = new List<ReportEntity>();
                }
                dictReports[rep.ReportTerroist.nameTrrorist].Add(rep);
            }

            ReportEntity terrorist = GetMaxTerrorist(dictReports);
            string life ="";
            if (terrorist.ReportTerroist.statusTrrorist)
            {
                life = "live";
            }
            else
            {
                life = "dead";
            }



            
            string t = ($"name {terrorist.ReportTerroist.nameTrrorist} rank :{terrorist.ReportTerroist.typeRank} life :{life}" +
            $" weapons:{String.Join(" ",terrorist.ReportTerroist.Weapons)} ,score terrorist is {terrorist.ReportTerroist.GetScore} ");

            PrintSelection.PrintData(t);
            return terrorist;
        }

        private ReportEntity GetMaxTerrorist(Dictionary<string, List<ReportEntity>> dictReports)
        {
            int max = 0;
            ReportEntity? maxTerrorist = null;

            foreach (var rep in dictReports)
            {
                List<ReportEntity> list = rep.Value;

                ReportEntity last = list[list.Count - 1];
                //TerroristEntity current = last.ReportTerroist;

                if (last.ReportTerroist.GetScore > max)
                {
                    max = last.ReportTerroist.GetScore;
                    maxTerrorist = last;
                }
            }

            return maxTerrorist;
        }
    }
}
