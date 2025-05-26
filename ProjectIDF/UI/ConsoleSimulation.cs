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
        private StrikeExecution _strikeExecution;



        public ConsoleSimulation(CollectionUnits units, CollectionReportsEntity reports, IntelligenceAnalyzer analyzer, AttackAvailability attackAvailability,
            TargetPrioritization targetPrioritization , StrikeExecution strikeExecution)
        {
             _collectionUnits = units;
            _reports = reports;
            _analyzer = analyzer;
            _attackAvailability = attackAvailability;
            _targetPrioritization = targetPrioritization;
            _strikeExecution = strikeExecution;
        }

        public void Menu()
        {
            int choise = 0;
            Console.WriteLine(
                "Prese 1 to identifying the terrorist with most intelligence reports\n" +
                "Prese 2 to view all currently available attack units and their remaining capacity\n" +
                "Prese 3 to determining the most dangerous terrorist based on quality rating\n" +
                "Prese 4 to selecting an appropriate strike unit based on the location and type of terrorist\n");
            int.TryParse(Console.ReadLine(), out choise);
            this.GetChoice(choise);
        }
        public void GetChoice(int choise)
        {
            switch (choise)
            {
                case 1:
                    _analyzer.Analyzer(_reports.Collection);
                    break;
                case 2:
                    _attackAvailability.ReadyAttack(_collectionUnits.MyCollectionUnits);

                    break;
                case 3:
                    _targetPrioritization.MostDangerousTerrorist(_reports.Collection);
                    break;
                    //case 4:
                    //_strikeExecution.Execution(_reports.Collection);
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
