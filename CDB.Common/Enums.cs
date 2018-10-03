using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.Common
{
    public class Enums
    {
        public enum JobStatus : byte
        {
            Partial = 1,
            Disqualified = 2,
            Pending = 3,
            Active = 4,
            Suspended = 5,
            Former = 6,
            Deleted = 7
        }
    }
}
