using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityRepoBL.Interfaces;

namespace CityRepoDL
{
    public class CityRepository : ICityRepository
    {
        private string _connectionString;

        public CityRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
