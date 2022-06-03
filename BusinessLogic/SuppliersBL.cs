using AutoMapper;
using BusinessLogic.Model;
using DataAccess;
using DataAccess.Repository.Entities;

namespace BusinessLogic
{
    public class SuppliersBL
    {
        private readonly SuppliesDA _dataAccess;
        private readonly Mapper _mapper;

        public SuppliersBL()
        {
            _dataAccess = new DataAccess.SuppliesDA();
            var _mapperConfig = new MapperConfiguration(config => config.CreateMap<Supplier, SupplierModel>().ReverseMap());
            _mapper = new Mapper(_mapperConfig);
        }

        public List<SupplierModel> GetSuppliers()
        {
            List<Supplier> supplier = _dataAccess.GetSuppliers();
            List<SupplierModel> result = _mapper.Map<List<Supplier>, List<SupplierModel>>(supplier);
            return result;
        }

        public SupplierModel GetSupplierById(int id)
        {
            var supplier = _dataAccess.GetSupplierById(id);
            SupplierModel result = _mapper.Map<Supplier, SupplierModel>(supplier);

            return result;
        }

        public void createSupplier(SupplierModel supplierModel)
        {
            Supplier createSupp = _mapper.Map<SupplierModel, Supplier>(supplierModel); 
            _dataAccess.createSupplier(createSupp);
        }
    }
}