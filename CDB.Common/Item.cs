using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.Common
{
    public class Item
    {
        public byte Id { get; set;}
        public string Text { get; set; }
        public string ArabicText { get; set; }

        public string DisplayText
        {
            get
            {
                return Text + Constants.DISPLAY_NAME_SEPARATOR + ArabicText;
            }
        }
    }
}
