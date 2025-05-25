using ProjectIDF.Entity;

namespace ProjectIDF.Logic.IntelligenceAnalysis

{
     public class IntelligenceAnalyzer
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
            TerroristEntity maxKey = collectionReports.Aggregate((a, b) => a.Value > b.Value ? a : b).Key;
            return maxKey;
        }
        
        
            
    }
}
