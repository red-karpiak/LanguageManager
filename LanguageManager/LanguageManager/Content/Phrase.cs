using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageManager.Content
{
    public class Phrase : Language
    {
        public string[] Characters { get; set; }

        public Phrase(int id, string spelling, string pronounciation, string definition) : 
            base(id, spelling, pronounciation, definition)
        {
            Characters = spelling.Split();
        }
    }
}
