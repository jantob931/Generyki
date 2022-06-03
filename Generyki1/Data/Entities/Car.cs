using System.Text;
using Generyki1.Data.Entities;

namespace Generyki1.Data.Entities
{
    public class Car : EntitiesBase
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal StandardCosr { get; set; }
        public decimal ListPrice { get; set; }
        public string Type { get; set; }
        // Calculated
        public int? NameLenght { get; set; }
        public decimal? TotalSales { get; set; }

        #region ToString Override
        public override string ToString()
        {
           StringBuilder sb = new (1024);
            sb.AppendLine($"{Name} ID: {Id}");
            sb.AppendLine($"color: {Color} Type: {Type} ");
            sb.AppendLine($"Cost: {StandardCosr:c} Price: {ListPrice}");
            if (NameLenght.HasValue)
            {
                sb.AppendLine($"Name Lenght {NameLenght}");
            }
            if (TotalSales.HasValue)
            {
                sb.AppendLine($"Total Sales: {TotalSales}");

            }
            return sb.ToString();


        }
        #endregion
    }
}
