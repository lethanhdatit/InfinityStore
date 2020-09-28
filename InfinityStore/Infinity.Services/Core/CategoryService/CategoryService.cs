using Infinity.Common;
using Infinity.Data;
using Infinity.DTOs;
using Infinity.Repositories;
using Infinity.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Services
{
    public class CategoryService : BaseService<Categories, CategoryMenu>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<Categories> _reponsitory => _unitOfWork.CategoryRepository;

        public IEnumerable<CategoryMenu> GetToShowMenu(string threeLetterISO, byte maxLv = 2)
        {
            var results = (new List<CategoryMenu>());
            results.Add(new CategoryMenu()
            {
                Id = 0,
                Name = "",
                ImgUrl = null,
                ParentId = null
            });

            var groups = _reponsitory.Find(x => x.Status == (byte)BaseStatus.Active, includeProperties: "CategoryTranslations.Language")
                                                       .AsEnumerable()
                                                       .GroupBy(i => i.ParentId);

            var roots = groups?.FirstOrDefault(g => g.Key.HasValue == false)?
                        .Select(s =>
                        {
                            var cateTransl = s.CategoryTranslations?.FirstOrDefault(f => f.Language?.ThreeLetterIso.ToUpper() == threeLetterISO.ToUpper());
                            return new CategoryMenu()
                            {
                                Id = s.Id,
                                ParentId = s.ParentId,
                                Name = cateTransl?.Name,
                                ImgUrl = cateTransl?.ImgUrl
                            };
                        })
                        .ToList();

            if(roots != null && roots.Any()) results.AddRange(roots);

            if (results != null && results.Count > 1)
            {
                var dict = groups?.Where(g => g.Key.HasValue).ToDictionary(g => g.Key.Value, g => g.Select(s => {
                    var cateTransl = s.CategoryTranslations?.FirstOrDefault(f => f.Language?.ThreeLetterIso.ToUpper() == threeLetterISO.ToUpper());
                    return new CategoryMenu()
                    {
                        Id = s.Id,
                        ParentId = s.ParentId,
                        Name = cateTransl?.Name,
                        ImgUrl = cateTransl?.ImgUrl
                    };
                })
                .ToList());
                for (int i = 0; i < results.Count; i++)
                    AddChildren(results[i], dict);
            }

            return results;
        }
        private static void AddChildren(CategoryMenu node, IDictionary<long, List<CategoryMenu>> source)
        {
            if (source.ContainsKey(node.Id))
            {
                node.Children = source[node.Id];
                for (int i = 0; i < node.Children.Count; i++)
                    AddChildren(node.Children[i], source);
            }
            else
            {
                node.Children = new List<CategoryMenu>();
            }
        }
    }
}
