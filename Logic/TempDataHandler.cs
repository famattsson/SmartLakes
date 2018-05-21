using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;

namespace Logic
{
    public class TempDataHandler
    {
        static public TempRecord GetRecords (string fromDate, string toDate, List<string> locations)
        {
            return TempDataGetter.GetRecords(fromDate, toDate, locations);
        }
    }
}
