using LanguageManager.DataManagement;
using LanguageManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LanguageManager.Services
{
    public class RestService : IRestService
    {
        public Task Delete(DataEntry entry, int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DataEntry>> Get(DataEntry entry)
        {
            throw new NotImplementedException();
        }

        public Task Save(DataEntry entry)
        {
            throw new NotImplementedException();
        }
    }
}
