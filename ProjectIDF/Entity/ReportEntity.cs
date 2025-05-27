using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Enums;


namespace ProjectIDF.Entity
{
    internal class ReportEntity
    {
        private TerroristEntity Terroist;
        private TerroristLocation Location;
        private DateTime Timestamp;

        public ReportEntity(TerroristEntity terroist, TerroristLocation location, DateTime time)
        {
            Terroist = terroist;
            Location = location;
            Timestamp = time;
        }
        




        public TerroristEntity ReportTerroist
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
        public override string ToString()
        {

            return $"terrorist name: {ReportTerroist.nameTrrorist},Rank :{ReportTerroist.typeRank} " +
                $"Status life: {ReportTerroist.statusTrrorist}, Weapons:{String.Join("," , ReportTerroist.Weapons)} " +
                $"Score : {ReportTerroist.GetScore} Timestamp : {ReportTimestamp}";
        }
       
    }
}
