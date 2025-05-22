using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Enemy;

namespace ProjectIDF.IDF.Aman.IntelligenceAnalysis
{
    internal class TargetPrioritization
    {

        public Terrorist MostDangerousTerrorist(List<Report> reports) {

            Terrorist ter;
            Dictionary<string, List<Report>> dictReports = new Dictionary<string, List<Report>>();

            foreach(Report rep in reports)
            {
                if (dictReports.ContainsKey(rep.ReportTerroist.nameTrrorist)) {

                    dictReports[rep.ReportTerroist.nameTrrorist] = new List<Report>();
                }
                else
                {
                    dictReports[rep.ReportTerroist.nameTrrorist].Add(rep);
                }
            }


            Terrorist terror = GetMaxTerrorist(dictReports);

            return ter;
        }

        private Terrorist GetMaxTerrorist(Dictionary<string, List<Report>> dictReports)
        {
            int max = 0;
            Terrorist maxTerrorist =null;
            foreach (var rep in dictReports) {
              
                List<Report> list = rep.Value;

                Report last = list[list.Count - 1];
                Terrorist current=last.ReportTerroist;
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
