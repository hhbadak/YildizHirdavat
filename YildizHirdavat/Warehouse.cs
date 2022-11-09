using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace YildizHirdavat
{
    public class Warehouse
    {
        GardenMaterial[] gardenMaterials;
        MeasuringDevice[] measuringDevices;
        Nail[] nails;
        Paint[] paints;
        RepairGroup[] repairGroups;
        Screw[] screws;
        Vitrified[] vitrifieds;
        WorkSafety[] workSafetys;

        public Warehouse()
        {
            gardenMaterials = new GardenMaterial[0];
            measuringDevices = new MeasuringDevice[0];
            nails = new Nail[0];
            paints = new Paint[0];
            repairGroups = new RepairGroup[0];
            screws = new Screw[0];
            vitrifieds = new Vitrified[0];
            workSafetys = new WorkSafety[0];
        }
        public void Add(GardenMaterial gm)
        {
            GardenMaterial[] test = new GardenMaterial[gardenMaterials.Length + 1];
            Array.Copy(gardenMaterials, test, gardenMaterials.Length);
            test[test.Length - 1] = gm;
            gardenMaterials = test;

        }
        public void Add(MeasuringDevice md)
        {
            MeasuringDevice[] test = new MeasuringDevice[measuringDevices.Length + 1];
            Array.Copy(measuringDevices, test, measuringDevices.Length);
            test[test.Length - 1] = md;
            measuringDevices = test;
        }
        public void Add(Nail n)
        {
            Nail[] test = new Nail[nails.Length + 1];
            Array.Copy(nails, test, nails.Length);
            test[test.Length - 1] = n;
            nails = test;
        }
        public void Add(Paint p)
        {
            Paint[] test = new Paint[paints.Length + 1];
            Array.Copy(paints, test, paints.Length);
            test[test.Length - 1] = p;
            paints = test;
        }
        public void Add(RepairGroup rg)
        {
            RepairGroup[] test = new RepairGroup[repairGroups.Length + 1];
            Array.Copy(repairGroups, test, repairGroups.Length);
            test[test.Length - 1] = rg;
            repairGroups = test;
        }
        public void Add(Screw s)
        {
            Screw[] test = new Screw[screws.Length + 1];
            Array.Copy(screws, test, screws.Length);
            test[test.Length - 1] = s;
            screws = test;
        }
        public void Add(Vitrified v)
        {
            Vitrified[] test = new Vitrified[vitrifieds.Length + 1];
            Array.Copy(vitrifieds, test, vitrifieds.Length);
            test[test.Length - 1] = v;
            vitrifieds = test;
        }
        public void Add(WorkSafety ws)
        {
            WorkSafety[] test = new WorkSafety[workSafetys.Length + 1];
            Array.Copy(workSafetys, test, workSafetys.Length);
            test[test.Length - 1] = ws;
            workSafetys = test;
        }
        public void Product()
        {
            GardenMaterial gm = new GardenMaterial()
            {
                productCode = 101,
                productName = "Çardak",
                productFeatures = "6 Kişilik 4 Mevsim Özellikli",
                brand = "BDK",
                electronic = false,
                unit = "Adet",
                price = 4.750,
                stock = 12
            };
            Add(gm);
            GardenMaterial gm1 = new GardenMaterial()
            {
                productCode = 102,
                productName = "Bahçe Makası",
                productFeatures = "Darbe Emici, Ayarlanılabilir, Yumuşak Tutamaklar",
                brand = "Çebi",
                electronic = false,
                unit = "Adet",
                price = 420,
                stock = 25
            };
            Add(gm1);
            GardenMaterial gm2 = new GardenMaterial()
            {
                productCode = 103,
                productName = "Çardak",
                productFeatures = "6 Kişilik 4 Mevsim Özellikli",
                brand = "BDK",
                electronic = false,
                unit = "Adet",
                price = 4.750,
                stock = 12
            };
            Add(gm2);
            GardenMaterial gm3 = new GardenMaterial()
            {
                productCode = 104,
                productName = "Çardak",
                productFeatures = "6 Kişilik 4 Mevsim Özellikli",
                brand = "BDK",
                electronic = false,
                unit = "Adet",
                price = 4.750,
                stock = 12
            };
            Add(gm3);
            GardenMaterial gm4 = new GardenMaterial()
            {
                productCode = 105,
                productName = "Çardak",
                productFeatures = "6 Kişilik 4 Mevsim Özellikli",
                brand = "BDK",
                electronic = false,
                unit = "Adet",
                price = 4.750,
                stock = 12
            };
            Add(gm4);

        }
        public void List()
        {
            #region PRODUCT LIST
            string[] product = new string[8];
            product[0] = "Bahçe Malzemeleri";
            product[1] = "Boya";
            product[2] = "Çivi";
            product[3] = "İş Güvenlik Malzemeleri";
            product[4] = "Ölçüm Aletleri";
            product[5] = "Tamir Aletleri";
            product[6] = "Vida";
            product[7] = "Vitrifiye";

            #endregion
            string select = "e";
            Console.WriteLine("                          Y I L D I Z   H I R D A V A T");
            Console.WriteLine("                            * H O Ş G E L D İ N İ Z *");
            while (select == "e")
            {
                Console.WriteLine("Hangi Ürün Grubundan Alışveriş Yapmak İstersiniz");
                for (int i = 0; i < product.Length; i++)
                {
                    Console.WriteLine($"{i + 1}-) {product[i]}");
                }
                string secim = Console.ReadLine();
                //Console.ReadLine();
                while (secim != "1" && secim != "2" && secim != "3" && secim != "4" && secim != "5" && secim != "6" && secim != "7" && secim != "8")
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız Lütfen Tekrar Deneyiniz");
                    secim = Console.ReadLine();
                }
                if (secim == "1")
                {
                    
                    Console.WriteLine("Bahçe Malzemeleri Bölümüne Hoşgeldiniz");
                    for (int i = 0; i < gardenMaterials.Length; i++)
                    {
                        Console.WriteLine(gardenMaterials[i].Print());
                    }
                }
                else if (secim == "2")
                {
                    Paint p = new Paint();
                    Console.WriteLine(p.Print());
                }
                else if (secim == "3")
                {
                    Nail n = new Nail();
                    Console.WriteLine(n.Print());
                }
                else if (secim == "4")
                {

                }
                else if (secim == "5")
                {

                }
                else if (secim == "6")
                {

                }
                else if (secim == "7")
                {

                }
                else if (secim == "8")
                {

                }
                Console.WriteLine("Alışverişe Devam Etmek İster Misiniz? E/H ");
                select = Console.ReadLine();
                select.ToLower();
            }
        }
    }
}
