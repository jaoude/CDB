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
            new Item() { Id = 1, Text = "Bank Audi SAL"},
            new Item() { Id = 2, Text = "Banque Misr Liban SAL" },
            new Item() { Id = 3, Text = "Arab Bank PLC"},
            new Item() { Id = 4, Text = "Rafidain Bank"},
            new Item() { Id = 5, Text = "Fransabank SAL"},
            new Item() { Id = 6, Text = "Banque Libano – Francaise SAL"},
            new Item() { Id = 7, Text = "BLC Bank SAL"},
            new Item() { Id = 8, Text = "BLOM Bank SAL"},
            new Item() { Id = 9, Text = "Federal Bank of Lebanon SAL"},
            new Item() { Id = 10, Text = "Société Générale de Banque au Liban SAL"},
            new Item() { Id = 11, Text = "Bank Med SAL"},
            new Item() { Id = 12, Text = "Audi Private Bank SAL"},
            new Item() { Id = 13, Text = "BBAC SAL"},
            new Item() { Id = 14, Text = "Audi Investment Bank SAL"},
            new Item() { Id = 15, Text = "Syrian Lebanese Commercial Bank SAL"},
            new Item() { Id = 16, Text = "Banque de Crédit National SAL"},
            new Item() { Id = 17, Text = "Byblos Bank SAL"},
            new Item() { Id = 18, Text = "Banque de l’Habitat SAL"},
            new Item() { Id = 19, Text = "Finance Bank SAL"},
            new Item() { Id = 20, Text = "Saradar Bank SAL"},
            new Item() { Id = 21, Text = "IBL Bank SAL"},
            new Item() { Id = 22, Text = "Credit Libanais SAL"},
            new Item() { Id = 23, Text = "Fenicia Bank SAL"},
            new Item() { Id = 24, Text = "North Africa Commercial Bank SAL"},
            new Item() { Id = 25, Text = "Lebanese Swiss Bank SAL"},
            new Item() { Id = 26, Text = "Bank Saderat Iran"},
            new Item() { Id = 27, Text = "BSL Bank SAL"},
            new Item() { Id = 28, Text = "National Bank of Kuwait (Lebanon) SAL"},
            new Item() { Id = 29, Text = "Bank of Beirut SAL"},
            new Item() { Id = 30, Text = "Jammal Trust Bank SAL"},
            new Item() { Id = 31, Text = "Habib Bank Limited"},
            new Item() { Id = 32, Text = "Arab African International Bank"},
            new Item() { Id = 33, Text = "Emirates Lebanon Bank SAL"},
            new Item() { Id = 34, Text = "Banque Bemo SAL"},
            new Item() { Id = 35, Text = "Lebanon and Gulf Bank SAL"},
            new Item() { Id = 36, Text = "Saudi Lebanese Bank SAL"},
            new Item() { Id = 37, Text = "Cedrus Bank SAL"},
            new Item() { Id = 38, Text = "AM Bank SAL"},
            new Item() { Id = 39, Text = "Credit Bank SAL"},
            new Item() { Id = 40, Text = "United Credit Bank SAL"},
            new Item() { Id = 41, Text = "Bank Al Madina SAL"},
            new Item() { Id = 42, Text = "First National Bank SAL"},
            new Item() { Id = 43, Text = "Al Baraka Bank SAL"},
            new Item() { Id = 44, Text = "MEAB SAL"},
            new Item() { Id = 45, Text = "BLOMINVEST Bank SAL"},
            new Item() { Id = 46, Text = "Med Investment Bank SAL"},
            new Item() { Id = 47, Text = "Credit Libanais Investment Bank SAL"},
            new Item() { Id = 48, Text = "Citibank NA"},
            new Item() { Id = 49, Text = "Arab Investment Bank"},
            new Item() { Id = 50, Text = "Fransa Invest Bank SAL"},
            new Item() { Id = 51, Text = "Byblos Invest Bank SAL"},
            new Item() { Id = 52, Text = "Arab Finance House SAL (Islamic Bank)"},
            new Item() { Id = 53, Text = "Lebanese Islamic Bank SAL"},
            new Item() { Id = 54, Text = "BLOM Development Bank SAL"},
            new Item() { Id = 55, Text = "FFA SAL (Private Bank)"},
            new Item() { Id = 56, Text = "Bank of Beirut Invest SAL"},
            new Item() { Id = 57, Text = "Bank of Baghdad (Private S.A.Co.)"},
            new Item() { Id = 58, Text = "CSC Bank SAL"},
            new Item() { Id = 59, Text = "AL – Bilad Islamic Bank for Investment &Finance P.S.C."},
            new Item() { Id = 60, Text = "IBL Investment Bank SAL"},
            new Item() { Id = 61, Text = "Qatar National Bank (Qatari Societe Anonyme)"},
            new Item() { Id = 62, Text = "Cedrus Invest Bank SAL"},
            new Item() { Id = 63, Text = "BLC Invest SAL"},
            new Item() { Id = 64, Text = "Li Bank SAL (Levant Investment Bank)"},
            new Item() { Id = 65, Text = "Invest Bank"},
            new Item() { Id = 66, Text = "Lucid Investment Bank SAL"},

        };
        public static List<Item> Governates = new List<Item>()
        {
            new Item() { Id = 1, Text = "Aakkar ", ArabicText = "عكار"},
            new Item() { Id = 2, Text = " Baalbek-Hermel", ArabicText = "بعلبك الهرمل"},
            new Item() { Id = 3, Text = "Beirut", ArabicText = " بيروت"},
            new Item() { Id = 4, Text = "Beqaa ", ArabicText = "البقاع"},
             new Item() { Id = 5, Text = "Mount Lebanon", ArabicText = " جبل لبنان"},
            new Item() { Id = 6, Text = "Nabatiyeh ", ArabicText = "النبطية "},
            new Item() { Id = 7, Text = "North Lebanon ", ArabicText = "شمال لبنان "},
             new Item() { Id = 8, Text = "South Lebanon", ArabicText = " جنوب لبنان"}
          
        };

        public static List<Item> Kaza = new List<Item>()
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
