using System;

namespace _05.Builder
{
    /// <summary>
    /// Amaç birbiri ardına izlenecek adımlarn bir nesne çıkarmasını sağlamak olarak düşünlebilir.
    /// iş katmanında kodları if if yazmak yerine üreticinin enjekte edilmesini sağlayarak yapılması örnek olabilir.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            OldCustomerProductBuilder CustomerBuilder = new OldCustomerProductBuilder();

            director.GenereateProduct(CustomerBuilder);

            ProductViewModel model = CustomerBuilder.GetModel();
            Console.WriteLine(model.ID);
            Console.WriteLine(model.Name);
            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.UnitInPrice);
            Console.WriteLine(model.DiscountedPrice);



            Console.Read();

        }
    }

    /// <summary>
    /// Ortaya çıkacak olan nesne
    /// </summary>
    public class ProductViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitInPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }
    }

    /// <summary>
    /// işlemlerin uygulandığı builder sınıfı
    /// </summary>
    public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel();
    }

    /// <summary>
    /// yeni müşteriye yüzde10 discount yapıyor.
    /// </summary>
    public class NewCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel productModel = new ProductViewModel();

        public override void GetProductData()
        {
            productModel.ID = 1;
            productModel.CategoryName = "Beverages";
            productModel.Name = "Chai";
            productModel.UnitInPrice = 20;
        }

        public override void ApplyDiscount()
        {
            productModel.DiscountedPrice = productModel.UnitInPrice * (decimal)0.90;
            productModel.DiscountApplied = true;
        }

        public override ProductViewModel GetModel()
        {
            return productModel;
        }
    }
    /// <summary>
    /// eski müşteriye yüzde30 discount uyguluyor.
    /// </summary>
    public class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel productModel = new ProductViewModel();

        public override void GetProductData()
        {
            productModel.ID = 1;
            productModel.CategoryName = "Beverages";
            productModel.Name = "Chai";
            productModel.UnitInPrice = 20;
        }

        public override void ApplyDiscount()
        {
            productModel.DiscountedPrice = productModel.UnitInPrice * (decimal)0.70;
            productModel.DiscountApplied = true;
        }

        public override ProductViewModel GetModel()
        {
            return productModel;
        }
    }

    /// <summary>
    /// Yapılacak işlemler
    /// </summary>
    public class Director
    {
        public void GenereateProduct(ProductBuilder builder)
        {
            builder.GetProductData();
            builder.ApplyDiscount();
        }
    }
}
