using ProjectIDF.Entity;
using ProjectIDF.UI;

namespace ProjectIDF.Logic.IntelligenceAnalysis

{
     internal class IntelligenceAnalyzer
    {
        public TerroristEntity Analyzer(List<ReportEntity> reportList)
        {

          
            Dictionary<TerroristEntity, int> collectionReports = new Dictionary<TerroristEntity, int>();  
            foreach (ReportEntity report in reportList)
            {
                TerroristEntity terrorist = report.ReportTerroist;
                if (collectionReports.ContainsKey(terrorist))
                {
                    collectionReports[terrorist]++;
                }
                else
                {
                    collectionReports[terrorist] = 1;
                }
            }

            TerroristEntity result = TerroristMostReports(collectionReports);

            
            return result;
        }
        
        static TerroristEntity TerroristMostReports(Dictionary<TerroristEntity, int> collectionReports)
        {
           
            int max = 0;
            TerroristEntity maxTerrorist = null!;

            foreach (var rep in collectionReports)
            {
                

                if (rep.Value> max)
                {
                    max = rep.Value;
                    maxTerrorist = rep.Key;
                }
            }

            return maxTerrorist;
        }
        
        
            
    }
}
