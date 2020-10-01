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
    public class CategoryService : BaseService<Categories, CategoryNode>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<Categories> _reponsitory => _unitOfWork.CategoryRepository;

        public IEnumerable<CategoryNode> BuildCategoryTree(string threeLetterISO, byte maxSubLv)
        {
            var tree = (new List<CategoryNode>());
            tree.Add(new CategoryNode()
            {
                Id = 0,
                Name = "",
                ImgUrl = null,
                ParentId = null,
                SeoUrl = $"/shopping/index/"
            });

            var groups = _reponsitory.Find(x => x.Status == (byte)BaseStatus.Active, includeProperties: "CategoryTranslations.Language")
                                                       .AsEnumerable()
                                                       .GroupBy(i => i.ParentId);

            var roots = groups?.FirstOrDefault(g => g.Key.HasValue == false)?
                        .Select(s =>
                        {
                            var cateTransl = s.CategoryTranslations?.FirstOrDefault(f => f.Language?.ThreeLetterIso.ToUpper() == threeLetterISO.ToUpper());
                            return new CategoryNode()
                            {
                                Id = s.Id,
                                ParentId = s.ParentId,
                                Name = cateTransl?.Name,
                                ImgUrl = cateTransl?.ImgUrl,
                                SeoUrl = $"/shopping/index/categoryId={s.Id}"
                            };
                        })
                        .ToList();

            if(roots != null && roots.Any()) tree.AddRange(roots);

            if (tree != null && tree.Count > 1)
            {
                var dict = groups?.Where(g => g.Key.HasValue).ToDictionary(g => g.Key.Value, g => g.Select(s => {
                    var cateTransl = s.CategoryTranslations?.FirstOrDefault(f => f.Language?.ThreeLetterIso.ToUpper() == threeLetterISO.ToUpper());
                    return new CategoryNode()
                    {
                        Id = s.Id,
                        ParentId = s.ParentId,
                        Name = cateTransl?.Name,
                        ImgUrl = cateTransl?.ImgUrl,
                        SeoUrl = $"/shopping/index/categoryId={s.Id}"
                    };
                })
                .ToList());
                for (int i = 0; i < tree.Count; i++)
                    AddChildren(tree[i], dict, maxSubLv);
            }

            return tree;
        }
        private static void AddChildren(CategoryNode node, IDictionary<long, List<CategoryNode>> source, int maxSubLv)
        {
            if (source.ContainsKey(node.Id) && maxSubLv > 0)
            {
                maxSubLv--;
                node.Children = source[node.Id];
                for (int i = 0; i < node.Children.Count; i++)
                    AddChildren(node.Children[i], source, maxSubLv);
            }
            else
            {
                node.Children = new List<CategoryNode>();
            }
        }
    }
}
