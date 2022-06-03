using Generyki1.Components.Csv_Reader.extensions;
using Generyki1.Components.Csv_Reader.Models;

namespace Generyki1.Components.Csv_Reader
{
    public class CsvReader : ICsvReader
    {
        public List<Car> ProcessCar(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<Car>();
            }
            var cars = File.ReadAllLines(filePath)
                .Skip(1)
                .Where(l => l.Length > 1)
                .ToCar();
                return cars.ToList();
        }
    }
}
