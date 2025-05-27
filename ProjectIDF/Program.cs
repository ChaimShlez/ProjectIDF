using ProjectIDF.Base;
using ProjectIDF.Entity;
using ProjectIDF.Entity.StrikeUnitsEntity;
using ProjectIDF.Enums;
using ProjectIDF.Logic.IntelligenceAnalysis;
using ProjectIDF.UI;
using ProjectIDF.Logic.Attacks;

namespace ProjectIDF
{
    class Proram
    {
        static void Main(string[] args)
        {
            var collectionUnits = new CollectionUnits();
            var reports = new CollectionReportsEntity();
            var analyzer = new IntelligenceAnalyzer();
            var attackAvailability = new AttackAvailability();
            var targetPrioritization = new TargetPrioritization();
           
           


            TerroristEntity muchamad = new TerroristEntity("mochamad", 2, true, new List<WeaponsEnum> { WeaponsEnum.GUN, WeaponsEnum.M16 });


            ReportEntity reprotMuchamad = new ReportEntity(muchamad, TerroristLocation.HOME, DateTime.Now);
            reports.AddReports(reprotMuchamad);
          Console.WriteLine ("cdscs"+ reports.Collection.Count());

            collectionUnits.AddUnits(new F16Plane("F16", 10, 0.5f, new List<TerroristLocation> { TerroristLocation.HOME }));
            collectionUnits.AddUnits(new Artillery("Artillery", 12, 0.5f, new List<TerroristLocation> { TerroristLocation.OUTSIDE }));

            var simulation = new ConsoleSimulation(collectionUnits, reports, analyzer, attackAvailability, targetPrioritization);
            simulation.Menu();

        }
    }
}