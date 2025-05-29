using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Base;
using ProjectIDF.Entity.StrikeUnitsEntity;

namespace ProjectIDF.Logic.Attacks
{
    internal class EnergyRefillVisitor : IUnitVisitor
    {

       public void VisitDrones(Drones drone)
        {
            drone.Recharge();
        }
         public void VisitF16Plane(F16Plane F16)
        {
            F16.Refuel();
        }
          public void VisitArtillery(Artillery artillery)
        {
            artillery.Refuel();
        }
    }
}
