using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class TempDataGetter
    {
        static public TempRecord GetRecords (string fromDate, string toDate, List<string> locations)
        {
            using (var db = new SmartLakesEntities())
            {
                /*var query = from tempRecord in db.TempRecords 
                            where*/ //Write rest of query once database is finalized
                return null;
            }
        }
    }
}