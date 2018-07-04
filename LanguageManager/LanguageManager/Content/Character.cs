using LanguageManager.DataManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageManager.Content
{
    public class Character : Language
    {
        public Character(int id, string spelling, string pronounciation, string definition) :
            base(id, spelling, pronounciation, definition)
        { }
    }
}
