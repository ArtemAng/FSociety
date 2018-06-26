using FSociety.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSociety.Domain.Abstract
{
    public interface INovelsRepository
    {
        IEnumerable<Novel> Novels { get; }
    }
}
