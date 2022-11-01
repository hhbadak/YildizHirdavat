using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizHirdavat
{
    public class Paint
    {
        public int productCode;
        public string productName;
        public string productFeatures;
        public string colour;
        public string brand;
        public bool exterior;
        public string unit;
        public double price;
        public int stock;
        public string Print()
        {
            return $"Ürün Kodu: {productCode}\nÜrün Adı: {productName}\nÜrün Özellikleri: {productFeatures}\nRenk: {colour}Ürün Markası: {brand}\nDış Cephe Özelliği: {exterior}\nFiyat: {price}\nKalan Stok: {stock}";
        }
    }
}
