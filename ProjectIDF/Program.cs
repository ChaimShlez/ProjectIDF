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
            var strikeExecution = new StrikeExecution();

            collectionUnits.AddUnits(new F16Plane("F16", 4, 0.5f, new List<TerroristLocation> { TerroristLocation.HOME }));
            collectionUnits.AddUnits(new Artillery("Artillery", 12, 0.5f, new List<TerroristLocation> { TerroristLocation.OUTSIDE }));

            var simulation = new ConsoleSimulation(collectionUnits, reports, analyzer, attackAvailability, targetPrioritization, strikeExecution);
            simulation.Menu();

        }
    }
}