using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pattern.Model;
using Pattern.UnitOfWork;

namespace Pattern.Repository
{

    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository(IUnitOfWork unitOfwork) : base(unitOfwork)
        {
        }
    }
}