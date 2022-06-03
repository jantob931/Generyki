using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generyki1.Data.Entities;

namespace Generyki1.Components.DataProviders.Extensions
{
    public static class CarsHelper
    {
    public static IEnumerable<Car> ByColor(this IEnumerable<Car> query,string color)
        {
            return query.Where(c => c.Color == color);
        }
    }
}
