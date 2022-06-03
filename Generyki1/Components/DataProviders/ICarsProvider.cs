using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generyki1.Data.Entities;

namespace Generyki1.Components.DataProviders
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
        //first last single
        Car FirstByColor(string color);
        Car LastByColor(string color);
        Car FirstOrDeafultByColorWithFDeafult(string color);
        Car SingleById(int id);
        Car SingleOrDeafultById(int id);
        Car FirstOrDeafultByColor(string color);
        //take'=
        List<Car> TakeCars(int howMany);
        List<Car> TakeCars(Range range);
        List<Car> TakeCarsWhileNameStartsWith(string prefix);
        //Skip
        List<Car> SkipCars(int HowMany);
        List<Car> SkipCarsWhileNameStartWith(string prefix);
        //Distinct
        List<string> DistinctAllColors();
        List<Car> DistinctByColor();
        //Chunk
        List<Car[]> ChunkCars(int size);



    }

    
}
