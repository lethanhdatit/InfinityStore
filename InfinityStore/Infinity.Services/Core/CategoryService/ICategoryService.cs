using Infinity.Data;
using Infinity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Services
{
    public interface ICategoryService : IBaseService<Categories, CategoryNode>
    {
        IEnumerable<CategoryNode> BuildCategoryTree(string threeLetterISO, byte maxLv);
    }
}
