using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaDeVentas.Productos
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public int? MinimumStock { get; set; }
        public int? InitialStock { get; set; }
        public String SizesId { get; set; }

        // Constructor por defecto
        public Product()
        {
        }

        // Constructor con todos los parámetros, opcional dependiendo de tus necesidades
        public Product(int id, string code, string description, decimal? cost, decimal? price, int? minimumStock, int? initialStock, string sizesId)
        {
            Id = id;
            Code = code;
            Description = description;
            Cost = cost;
            Price = price;
            MinimumStock = minimumStock;
            InitialStock = initialStock;
            SizesId = sizesId;
        }
    }


public class Size
    {
        public int Id { get; set; }
        public string SizeName { get; set; }

        // Constructor por defecto
        public Size()
        {
        }

        // Constructor con todos los parámetros, opcional dependiendo de tus necesidades
        public Size( string sizeName)
        {
            SizeName = sizeName;
        }
    }

}
