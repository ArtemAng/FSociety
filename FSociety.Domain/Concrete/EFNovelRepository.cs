using FSociety.Domain.Abstract;
using FSociety.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSociety.Domain.Concrete
{
    public class EFNovelRepository : INovelsRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Novel> Novels
        {
            get { return context.Novels; }
        }
    }
}
