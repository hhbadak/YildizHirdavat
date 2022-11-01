using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizHirdavat
{
    public class Vitrified
    {
        public int productCode;
        public string productName;
        public string productFeatures;
        public string brand;
        public string model;
        public string colour;
        public string unit;
        public double price;
        public int stock;
        public string Print()
        {
            return $"Ürün Kodu: {productCode}\nÜrün Adı: {productName}\nÜrün Özellikleri: {productFeatures}\nÜrün Markası: {brand}\nÜrün Modeli: {model}\nRenk: {colour}\nFiyat: {price}\nKalan Stok: {stock}";
        }
    }
}
