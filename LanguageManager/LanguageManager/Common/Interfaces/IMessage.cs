using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageManager.Common.Interfaces
{
    interface IMessage
    {
        void ShowError(string title, string message, string close);
    }
}
