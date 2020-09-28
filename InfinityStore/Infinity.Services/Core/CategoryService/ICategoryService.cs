using Infinity.Data;
using Infinity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Services
{
    public interface ICategoryService : IBaseService<Categories, CategoryMenu>
    {
        IEnumerable<CategoryMenu> GetToShowMenu(string threeLetterISO, byte maxLv = 2);
    }
}
