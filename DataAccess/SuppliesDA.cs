using DataAccess.Repository;
using DataAccess.Repository.Entities;

namespace DataAccess
{
    public class SuppliesDA
    {
        public List<Supplier> GetSuppliers()
        {
            var dbContext = new SuppliersDbContext();
            return dbContext.Suppliers.ToList();
        }

        public Supplier GetSupplierById(int id)
        {
            var dbContext = new SuppliersDbContext();
            var supp = new Supplier();

            supp = dbContext.Suppliers.FirstOrDefault(x => x.Id == id);

            return supp;
        }

        public void createSupplier(Supplier supplier)
        {
            var dbContext = new SuppliersDbContext();
            dbContext.Add(supplier);
            dbContext.SaveChanges();
        }
    }
}