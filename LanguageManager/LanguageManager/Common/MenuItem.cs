using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageManager.Common
{
    public class MenuItem
    {
        public string Title { get; set; }
        public Type TargetType { get; set; }

        public MenuItem(string title, Type targetType)
        {
            Title = title;
            TargetType = targetType;
        }
    }
}
