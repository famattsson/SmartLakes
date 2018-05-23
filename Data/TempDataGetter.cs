using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class TempDataGetter
    {
        static public List<TempRecords> GetRecords (string fromDate, string toDate, List<string> locations)
        {
            using (var db = new SmartLakesEntities())

            {
                if((fromDate != null && toDate != null) && (fromDate != "" && toDate != "") && locations.Count > 0  )
                {
                    var query = from tempRecord in db.TempRecords.ToList()
                                where DateTime.Parse(tempRecord.time) >= DateTime.Parse(fromDate) && DateTime.Parse(tempRecord.time) <= DateTime.Parse(toDate)
                                && locations.Contains(tempRecord.location)
                                orderby tempRecord.location
                                select tempRecord;
                    return query.ToList();
                }
                else if (fromDate != null && toDate != null)
                {
                    var query = from tempRecord in db.TempRecords
                                where locations.Contains(tempRecord.location)
                                orderby tempRecord.location
                                select tempRecord;
                    return query.ToList();
                }
                else if(locations != null && locations.Count > 0)
                {
                    var query = from tempRecord in db.TempRecords
                                where locations.Contains(tempRecord.location)
                                orderby tempRecord.location
                                select tempRecord;

                    return query.ToList();
                }
                else
                {
                    var query = from tempRecord in db.TempRecords
                                orderby tempRecord.location
                                select tempRecord;
                    return query.ToList();
                }

            }
        }
    }
}