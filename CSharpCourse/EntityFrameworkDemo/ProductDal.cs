using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            // ürünleri listelemek için =>
            // method bittiğinde bellekten zorla atması için using kullnılır
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        // girilen key'e göre arama yapar
        public List<Product> GetByName(string key)
        {
            // ürünleri listelemek için =>
            // method bittiğinde bellekten zorla atması için using kullnılır
            // veri tabanına where koşulu atıyor daha performaslı oluyor
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        // girilen price'e göre arama yapar
        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList();
            }
        }

        // 2 fiyat arası arama yapar
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }

        // tek bir ürünün bilgisine ulaşmak istenildiğinde
        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // girilen id ' ye uygun olan ilk kaydı getirir yoksa null getirir
                var result = context.Products.FirstOrDefault(p => p.Id == id);
                return result;
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); // gönderilen product ı veritabanındaki ile eşliyor
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
