using LanguageManager.DataManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageManager.Content
{
    public abstract class Language : DataEntry
    {
        public string Spelling { get; set; }
        public string Pronounciation { get; set; }
        public string Definition { get; set; }

        public Language(int id, string spelling, string pronounciation, string definition) : base(id)
        {
            Spelling = spelling;
            Pronounciation = pronounciation;
            Definition = definition;
        }
    }
}
