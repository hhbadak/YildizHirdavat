using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizHirdavat
{
    public class GardenMaterial
    {
        public int productCode;
        public string productName;
        public string productFeatures;
        public string brand;
        public bool electronic;
        public string unit;
        public double price;
        public int stock;
        public string Print()
        {
            return $"Ürün Kodu: {productCode}\nÜrün Adı: {productName}\nÜrün Özellikleri: {productFeatures}\nMarka: {brand}\nElektronik Özelliği: {electronic}\nBirim: {unit}\nFiyat: {price}\nKalan Stok: {stock}";
        }
    }
    
}
