using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;
using ProjectIDF.Entity;
using ProjectIDF.Entity.StrikeUnitsEntity;
using ProjectIDF.Logic.IntelligenceAnalysis;
using ProjectIDF.Logic.Attacks;

namespace ProjectIDF.UI
{
   internal class ConsoleSimulation
    {


        private CollectionUnits _collectionUnits;
        private CollectionReportsEntity _reports;
        private IntelligenceAnalyzer _analyzer;
        private AttackAvailability _attackAvailability;
        private TargetPrioritization _targetPrioritization;
        


        public ConsoleSimulation(CollectionUnits units, CollectionReportsEntity reports, IntelligenceAnalyzer analyzer, AttackAvailability attackAvailability,
            TargetPrioritization targetPrioritization )
        {
             _collectionUnits = units;
            _reports = reports;
            _analyzer = analyzer;
            _attackAvailability = attackAvailability;
            _targetPrioritization = targetPrioritization;
           
        }

        public void Menu()
        {
            int choise = 0;
            Console.WriteLine(
                "Press 1 to identifying the terrorist with most intelligence reports\n" +
                "Press 2 to view all currently available attack units and their remaining capacity\n" +
                "Press 3 to determining the most dangerous terrorist based on quality rating\n" +
                "Press 4 to selecting an appropriate strike unit based on the location and type of terrorist\n");
            int.TryParse(Console.ReadLine(), out choise);
            this.GetChoice(choise);
        }
        public void GetChoice(int choise)
        {
            switch (choise)
            {
                case 1:
                    TerroristEntity maxTerrorist = _analyzer.Analyzer(_reports.Collection);
                    Console.WriteLine(maxTerrorist);
                    break;
                case 2:
                   
                    List<AttackUnits> units =_attackAvailability.ReadyAttack(_collectionUnits.MyCollectionUnits);
                    Console.WriteLine(units.Count);
                    foreach (var item in units)
                    {
                        
                        Console.WriteLine(item);
                    }

                    break;
                case 3:
                    ReportEntity report = _targetPrioritization.MostDangerousTerrorist(_reports.Collection);
                    Console.WriteLine(report);
                    break;
                case 4:
                    int choiseUnit = 0;

                    ReportEntity reportOne = _targetPrioritization.MostDangerousTerrorist(_reports.Collection);
                    List<AttackUnits> unitsList = _attackAvailability.ReadyAttack(_collectionUnits.MyCollectionUnits);

                    int unitNumber = 1;
                    foreach (var item in unitsList)
                    {
                        Console.WriteLine($"press number {unitNumber} for {item}");
                        unitNumber++;
                    }

                    int.TryParse(Console.ReadLine(), out choiseUnit);

                       
                    ManegerAttack.MakeAttack(unitsList[choiseUnit - 1], reportOne);
                    

                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
