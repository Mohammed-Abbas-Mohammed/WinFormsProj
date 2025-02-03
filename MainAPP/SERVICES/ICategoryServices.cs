using DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAPP.SERVICES
{
    public interface ICategoryServices
    {
        public CreatCategoryDTO AddOne(CreatCategoryDTO entity);

        public CreatCategoryDTO UpdateOne(int id, CreatCategoryDTO entity);

        public void DeleteOne(int id);

        public CreatCategoryDTO GetOneByID(int id);

        public List<CreatCategoryDTO> GetAllItmes();
        public List<CreatCategoryDTO> Search(string keyWord);
    }
}
