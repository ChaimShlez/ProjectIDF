using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Entity;

namespace ProjectIDF.Logic.IntelligenceAnalysis
{
    internal class TargetPrioritization
    {

        public TerroristEntity MostDangerousTerrorist(List<ReportEntity> reports) {

          
            Dictionary<string, List<ReportEntity>> dictReports = new Dictionary<string, List<ReportEntity>>();

            foreach(ReportEntity rep in reports)
            {
                if (dictReports.ContainsKey(rep.ReportTerroist.nameTrrorist)) {

                    dictReports[rep.ReportTerroist.nameTrrorist] = new List<ReportEntity>();
                }
                else
                {
                    dictReports[rep.ReportTerroist.nameTrrorist].Add(rep);
                }
            }


            TerroristEntity terrorist = GetMaxTerrorist(dictReports);

            return terrorist;
        }

        private TerroristEntity GetMaxTerrorist(Dictionary<string, List<ReportEntity>> dictReports)
        {
            int max = 0;
            TerroristEntity maxTerrorist =null;
            foreach (var rep in dictReports) {
              
                List<ReportEntity> list = rep.Value;

                ReportEntity last = list[list.Count - 1];
                TerroristEntity current=last.ReportTerroist;
                if(current.GetScore > max)
                {
                    max = current.GetScore;
                    maxTerrorist = current;
                }

                    
                
            }
            return maxTerrorist;
        }
    }
}
