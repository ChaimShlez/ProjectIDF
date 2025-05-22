using ProjectIDF.Enemy;

namespace ProjectIDF.IDF.Aman.IntelligenceAnalysis

{
     public class IntelligenceAnalyzer
    {
        public Terrorist Analyzer(List<Report> reportList)
        {
            Dictionary<Terrorist, int> collectionReports = new Dictionary<Terrorist, int>();  
            foreach (Report report in reportList)
            {
                Terrorist terrorist = report.ReportTerroist;
                if (collectionReports.ContainsKey(terrorist))
                {
                    collectionReports[terrorist]++;
                }
                else
                {
                    collectionReports[terrorist] = 1;
                }
            }

            Terrorist result = TerroristMostReports(collectionReports);
            
            return result;
        }
        
        static Terrorist TerroristMostReports(Dictionary<Terrorist, int> collectionReports)
        {
            Terrorist maxKey = collectionReports.Aggregate((a, b) => a.Value > b.Value ? a : b).Key;
            return maxKey;
        }
        
        
            
    }
}
