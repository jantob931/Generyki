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
        //Select
        List<string> GetUniqueCarColor();
        decimal GetMinimumPriceOfAllCars();
        List<Car> GetSpecificColumns();
        string AnonymusClass();

        //Order
        List<Car> OrderByName();
        List<Car> OrderByNameDescending();
        List<Car> OrderByColorAndName();
        List<Car> OrderByColorAndNameDesc();
        //Where
        List<Car> WhereStartsWith(string prefix);
        List<Car> WhereStartsWithAndCostIsGreaterThan(string prefix, decimal cost);
        List<Car> WhereColorIs(string color);




    }

    
}
