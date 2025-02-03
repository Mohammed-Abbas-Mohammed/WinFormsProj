using DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAPP.SERVICES
{
    public interface IProductServices
    {
        public AdminProductDTO AddOne(AdminProductDTO entity);

        public AdminProductDTO UpdateOne(int id,AdminProductDTO entity);

        public void DeleteOne(int id);

        public AdminProductDTO GetOneByID(int id);

        public List<AdminProductDTO> GetAllItmes();
        public List<ClientProductDTO> Search(string keyWord);


    }
}
