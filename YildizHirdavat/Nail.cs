using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizHirdavat
{
    public class Nail
    {
        public int productCode;
        public string productName;
        public string productFeatures;
        public string boxContents;
        public double price;
        public int stock;
        public string Print()
        {
            return $"Ürün Kodu: {productCode}\nÜrün Adı:{productName}\nÜrün Özellikleri: {productFeatures}\nFiyat: {price}\n Kalan Stok: {stock}";
        }
    }
}
