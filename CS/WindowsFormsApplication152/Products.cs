using System;
using DevExpress.Xpo;
namespace DXSample
{
    public class Products : XPLiteObject
    {
        int fProductID;
        [Key(true)]
        public int ProductID
        {
            get { return fProductID; }
            set { SetPropertyValue<int>("ProductID", ref fProductID, value); }
        }
      
        int fQuantity;
        public int Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<int>("Quantity", ref fQuantity, value); }
        }

        decimal fPrice;
        public decimal Price
        {
            get { return fPrice; }
            set { SetPropertyValue<decimal>("Price", ref fPrice, value); }
        }

        string fProductName;
        public string ProductName
        {
            get { return fProductName; }
            set { SetPropertyValue<string>("ProductName", ref fProductName, value); }
        }

        bool fDiscontinued;

        public bool Discontinued
        {
            get { return fDiscontinued; }
            set { SetPropertyValue<bool>("Discontinued", ref fDiscontinued, value); }
        }

        public Products(Session session) : base(session) { }
        public Products() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}
