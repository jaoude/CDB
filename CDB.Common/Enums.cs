using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.Common
{
    public static class Enums
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

        public static List<Item> CompanyTypes = new List<Item>()
        {
            new Item() { Id = 1, Text = "SAL", ArabicText = ".ش.م.ل"},
            new Item() { Id = 2, Text = "SARL", ArabicText = ".ش.م.م"},
            new Item() { Id = 1, Text = "OffShore", ArabicText = "اوف شور"},
            new Item() { Id = 1, Text = "Holding", ArabicText = "هولدنغ"}
        };
    }
}
