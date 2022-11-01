using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizHirdavat
{
    public class RepairGroup
    {
        public int productCode;
        public string productName;
        public string productFeatures;
        public string brand;
        public bool electronic;
        public double price;
        public int stock;
        public string Print()
        {
            return $"Ürün Kodu: {productCode}\nÜrün Adı:{productName}\nÜrün Özellikleri: {productFeatures}\nÜrün Markası: {brand}\nElektronik Özelliği: {electronic}\nFiyat: {price}\n Kalan Stok: {stock}";
        }
    }
}
