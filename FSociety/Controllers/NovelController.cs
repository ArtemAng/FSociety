using FSociety.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSociety.Controllers
{
    public class NovelController : Controller
    {
        private INovelsRepository repository;
        public int pageSize = 4;
        public NovelController(INovelsRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(int page = 1)
        {
            //NovelListViewModel model = new NovelListViewModel
            //{
            //    Novels = repository.Novels
            //        .OrderBy(novel => novel.NovelID)
            //        .Skip((page - 1) * pageSize)
            //        .Take(pageSize),
            //    PagingInfo = new PagingInfo
            //    {
            //        CurrentPage = page,
            //        ItemsPerPage = pageSize,
            //        TotalItems = repository.Novels.Count()
            //    }
            //};
            return View(repository.Novels);
        }
    }
}