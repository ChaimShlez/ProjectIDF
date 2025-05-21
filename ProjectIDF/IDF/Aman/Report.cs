using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Enemy;
using ProjectIDF.Enums;


namespace ProjectIDF.IDF.Aman
{
    internal class Report
    {
        private Terrorist Terroist;
        private TerroristLocation Location;
        private DateTime Timestamp;

        public Report(Terrorist terroist, TerroristLocation location, DateTime time)
        {
            Terroist = terroist;
            Location = location;
            Timestamp = time;
        }
        




        public Terrorist ReportTerroist
        {
            get { return Terroist; }
            set { Terroist = value; }
        }

        public TerroristLocation TrreorLocation
        {
            get { return Location; }
            set { Location = value; }
        }

        public DateTime ReportTimestamp
        {
            get { return Timestamp; }
            set { Timestamp = value; }
        }






    }
}
