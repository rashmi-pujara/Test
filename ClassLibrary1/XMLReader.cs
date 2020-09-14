using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using Reader.Model;

namespace Reader
{
    public class XMLReader
    {
        public List<ProductData> RetrunListOfProducts()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/XMLFile1.xml");//Path of the xml script  
            DataSet ds = new DataSet();//Using dataset to read xml file  
            ds.ReadXml(xmlData);
            var products = new List<ProductData>();
            products = (from rows in ds.Tables[0].AsEnumerable()
                        select new ProductData
                        {
                            ProductId = Convert.ToInt32(rows[0].ToString()), //Convert row to int  
                            ProductName = rows[1].ToString(),
                            ProductCost = rows[2].ToString(),
                        }).ToList();
            return products;
        }
    }
}
