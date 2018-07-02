using LanguageManager.DataManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LanguageManager.Services.Interfaces
{
    public interface IRestService
    {
        Task<List<DataEntry>> Get(DataEntry entry);
        Task Save(DataEntry entry);
        Task Delete(DataEntry entry, int id);
    }
}
