using FSociety.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSociety.Models
{
    public class NovelListViewModel
    {
        public IEnumerable<Novel> Novels { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}