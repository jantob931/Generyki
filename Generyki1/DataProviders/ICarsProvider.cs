using Generyki1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyki1.DataProviders
{
    public interface ICarsProvider
    {
        List<string> GetUniqueCarColor();
        decimal GetMinimumPriceOfAllCars();
        List<Car> GetSpecificColumns();
        string AnonymusClass();
    }
    
}
