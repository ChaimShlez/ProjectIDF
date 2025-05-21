using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF.IDF.Aman
{
    internal class CollectionReports
    {

        private List<Report> Reprots;

        public CollectionReports()
        {
            Reprots = new List<Report>();
        }


       

        public List<Report> Collection
        {
            get { return Reprots; }
            set { Reprots = value; }
        }

    }
}
