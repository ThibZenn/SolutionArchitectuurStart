using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityRepoBL.Interfaces;
using CityRepoBL.Model;

namespace CityRepoBL.Managers
{
    public class CityManager
    {
		private ICityRepository _cityRepository;

        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public void AddCity(City city)
        {
			try
			{
				_cityRepository.AddCity(city);
			}
			catch (Exception ex)
			{

				throw new CityException("AddCity");
			}
        }
    }
}
