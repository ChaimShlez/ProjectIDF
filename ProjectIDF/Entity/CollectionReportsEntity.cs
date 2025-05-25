using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectIDF.Entity
{
    internal class CollectionReportsEntity
    {

        private List<ReportEntity> Reprots;
        //private Dictionary<Terrorist, List<Report>> DictCollection;

        public CollectionReportsEntity()
        {
            Reprots = new List<ReportEntity>();
            //DictCollection = new Dictionary<Terrorist, List<Report>>();
        }


       

        public List<ReportEntity> Collection
        {
            get { return Reprots; }
            set { Reprots = value; }
        }

        public void AddReports(ReportEntity entity)
        {
            Reprots.Add(entity);
        }

    }
}
