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
            new Item() { Id = 3, Text = "OffShore", ArabicText = "اوف شور"},
            new Item() { Id = 4, Text = "Holding", ArabicText = "هولدنغ"}
        };

        public static List<Item> Banks = new List<Item>()
        {
            new Item() { Id = 1, Text = "Audi ", ArabicText = "أودي"},
            new Item() { Id = 2, Text = "Credit Libanais", ArabicText = "الاعتماد اللبناني"},
            new Item() { Id = 3, Text = "Fransabank", ArabicText = " فرنسبنك"},
            new Item() { Id = 4, Text = "BLOM ", ArabicText = "لبنان والمهجر"}
        };

        public static List<Item> districts = new List<Item>()
        {
            new Item() { Id = 1, Text = "Baadba ", ArabicText = "بعبدا."},
            new Item() { Id = 2, Text = "Chouf", ArabicText = "الشوف"},
            new Item() { Id = 3, Text = "Aaley", ArabicText = "عاليه"},
            new Item() { Id = 4, Text = "Matn ", ArabicText = "المتن"},
              new Item() { Id = 5, Text = "Kesrouane ", ArabicText = "كسروان"},
            new Item() { Id = 6, Text = "Jbeil", ArabicText = "جبيل"},
            new Item() { Id = 7, Text = "Tripoli", ArabicText = "طرابلس"},
            new Item() { Id = 8, Text = "Batroun ", ArabicText = " البترون"},

               new Item() { Id = 9, Text = "Bcharreh ", ArabicText = "بشري"},
            new Item() { Id = 10, Text = "Zgharta", ArabicText = "زغرتا - الزاوية"},
            new Item() { Id = 11, Text = "Koura", ArabicText = "الكورة"},
            new Item() { Id = 12, Text = "Minieh-Danniyeh ", ArabicText = "الضنية"},
              new Item() { Id = 13, Text = "Aakkar ", ArabicText = "عكار"},
            new Item() { Id = 14, Text = "Zahleh", ArabicText = "زحلة"},
            new Item() { Id = 15, Text = "Beqaa Ouest", ArabicText = " البقاع الغربي"},
            new Item() { Id = 16, Text = "Rachaiya ", ArabicText = "راشيا"},

                 new Item() { Id = 17, Text = "Baalbek ", ArabicText = "بعلبك"},
            new Item() { Id = 18, Text = "Hermel", ArabicText = "الهرمل"},
            new Item() { Id = 19, Text = "Jezzine", ArabicText = " جزين"},
            new Item() { Id = 20, Text = "Sour ", ArabicText = "صور"},
              new Item() { Id = 21, Text = "Saida ", ArabicText = "صيدا"},
            new Item() { Id = 22, Text = "Nabatiyeh", ArabicText = "النبطية"},
            new Item() { Id = 23, Text = "Bent Jbeil", ArabicText = "بنت جبيل"},
            new Item() { Id = 24, Text = "Hasbaiya ", ArabicText = "حاصبيا"},
             new Item() { Id = 25, Text = "Marjaayoun ", ArabicText = "مرجعيون"}

        };
    }
}
