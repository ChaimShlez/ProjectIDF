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
           

            List<Report>Mus

            return ter;
        }
    }
}
