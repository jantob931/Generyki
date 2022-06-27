using Generyki1.Components.Csv_Reader.Models;

namespace Generyki1.Components.Csv_Reader
{
    public interface ICsvReader
    {
        List<Car> ProcessCar(string filePath);

        List<Manufacturer> ProcessManufacturer(string filePath);
    }
}
