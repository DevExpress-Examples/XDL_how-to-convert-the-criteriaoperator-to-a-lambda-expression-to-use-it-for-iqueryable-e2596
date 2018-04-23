using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Skins;

namespace DXSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = AccessConnectionProvider.GetConnectionString("MyDB.mdb");
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
            XpoDefault.Session = null;

            CreateData();

            SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void CreateData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                if (uow.FindObject<Products>(null) == null)
                {
                    Products product = new Products(uow);
                    product.Discontinued = false;
                    product.Price = 100;
                    product.Quantity = 20;
                    product.ProductName = "Orange";

                    product = new Products(uow);
                    product.Discontinued = true;
                    product.Price = 140;
                    product.Quantity = 50;
                    product.ProductName = "Apple";

                    product = new Products(uow);
                    product.Discontinued = false;
                    product.Price = 30;
                    product.Quantity = 120;
                    product.ProductName = "Banana";

                    product = new Products(uow);
                    product.Discontinued = true;
                    product.Price = 200;
                    product.Quantity = 80;
                    product.ProductName = "Grape";

                    product = new Products(uow);
                    product.Discontinued = false;
                    product.Price = 300;
                    product.Quantity = 10;
                    product.ProductName = "Garnet";

                    product = new Products(uow);
                    product.Discontinued = true;
                    product.Price = 120;
                    product.Quantity = 320;
                    product.ProductName = "Mandarin";

                    product = new Products(uow);
                    product.Discontinued = false;
                    product.Price = 250;
                    product.Quantity = 60;
                    product.ProductName = "Kiwi";

                    uow.CommitChanges();
                }
            }
        }
    }
}
