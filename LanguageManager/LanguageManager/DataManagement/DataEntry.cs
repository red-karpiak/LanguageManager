using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageManager.DataManagement
{
    public abstract class DataEntry
    {
        public int ID { get; set; }

        protected DataEntry(int id)
        {
            ID = id;
        }
    }
}
