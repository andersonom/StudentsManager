using StudentManager.Domain.Interfaces.Repositories;
using StudentsManager.DataMongo.Context;
using StudentsManager.Domain.Models;


namespace StudentsManager.DataMongo.Repositories
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(StudentsManagerContext context) : base(context)
        {
       
        }
    }
}
