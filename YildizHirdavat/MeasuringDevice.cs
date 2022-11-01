using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizHirdavat
{
    public class MeasuringDevice
    {
        public int productCode;
        public string productName;
        public string productFeatures;
        public string unit;
        public double price;
        public int stock;
        public string Print()
        {
            return $"Ürün Kodu: {productCode}\nÜrün Adı: {productName}\nÜrün Özellikleri: {productFeatures}\nFiyat: {price}\nKalan Stok: {stock}";
        }
    }
}
