using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pattern.UnitOfWork
{
    public interface IUnitOfWork
    {
        DbContext Context {get;}

        public Task SaveChangesAsync();
    }
}