
using AddPro;

using Autofac;
using MainAPP.SERVICES;
using Models;

namespace VisualCsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Container = AutoFacCopy.Inject();

            IProductServices ProService = Container.Resolve<IProductServices>();

            //ProService.AddOne(new DTOS.AdminProductDTO
            //{

            //    ProductName = "Chai",
            //    UnitPrice = 18,
            //    UnitsInStock = 39,
            //    Category = new Category{CategoryName= "Beverages" }
            //});
            //ProService.AddOne(new DTOS.AdminProductDTO
            //{
            //    ProductName = "Chang",
            //    UnitPrice = 19,
            //    UnitsInStock = 17,
            //    Category = new Category { CategoryName = "Beverages" }
            //});
            //ProService.AddOne(new DTOS.AdminProductDTO
            //{
            //    ProductName = "Aniseed Syrup",
            //    UnitPrice = 10,
            //    UnitsInStock = 13,
            //    Category = new Category { CategoryName = "Condiments" }
            //});



            foreach (var item in ProService.GetAllItmes())
            {
                Console.WriteLine(item);
            }
        }
    }
}
