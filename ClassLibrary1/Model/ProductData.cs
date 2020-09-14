using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reader.Model
{
    [Serializable]
    [XmlRoot("Products"),XmlType("Products")]
    public class ProductData
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCost { get; set; }
    }
}
