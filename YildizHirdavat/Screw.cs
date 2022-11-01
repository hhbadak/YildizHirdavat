using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizHirdavat
{
    public class Screw
    {
        public int productCode;
        public string productName;
        public string productFeatures;
        public string teethFeature;
        public double price;
        public string boxContents;
        public int stock;
        public string Print()
        {
            return $"Ürün Kodu: {productCode}\nÜrün Adı:{productName}\nÜrün Özellikleri: {productFeatures}\nDiş Özelliği: {teethFeature}\nFiyat: {price}\n Kalan Stok: {stock}";
        }
    }
}
