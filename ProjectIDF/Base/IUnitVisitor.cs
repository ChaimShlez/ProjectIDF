using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF.Entity.StrikeUnitsEntity;

namespace ProjectIDF.Base
{
    internal interface IUnitVisitor
    {

        void VisitDrones(Drones drone);
        void VisitF16Plane(F16Plane F16);
        void VisitArtillery(Artillery artillery);
    }
}
