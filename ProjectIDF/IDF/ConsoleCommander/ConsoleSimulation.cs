using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.IDF.Aman;
using ProjectIDF.IDF.Aman.IntelligenceAnalysis;
using ProjectIDF.Base;

namespace ProjectIDF.IDF.ConsoleCommander
{
    public class ConsoleSimulation
    {
        CollectionReports collectionReports = new CollectionReports();
        AttackAvailability attackAvailability = new AttackAvailability();
        List<AttackUnits> attackUnits = new List<AttackUnits>();

        public void Menu()
        {
            Console.WriteLine(
                "Prese 1 to identifying the terrorist with most intelligence reports\n" +
                "Prese 2 to view all currently available attack units and their remaining capacity\n" +
                "Prese 3 to determining the most dangerous terrorist based on quality rating\n" +
                "Prese 4 to selecting an appropriate strike unit based on the location and type of terrorist\n");
            int choice = int.Parse(Console.ReadLine());
            getChoice(choice);
        }
        public void getChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    IntelligenceAnalyzer.Analyzer(collectionReports.Collection);
                    break;
                case 2:
                    attackAvailability.ReadyAttack(attackUnits);
                    break;
            }
        }
    }
}
