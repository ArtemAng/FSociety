using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FSociety.Controllers;
using FSociety.Domain.Abstract;
using FSociety.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FSociety.Models;
using Moq;
using FSociety.HtmlHelpers;

namespace FSociety.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            // Организация (arrange)
            Mock<INovelsRepository> mock = new Mock<INovelsRepository>();
            mock.Setup(m => m.Novels).Returns(new List<Novel>
            {
                new Novel { NovelID = 1, Name = "Роман1"},
                new Novel { NovelID = 2, Name = "Роман2"},
                new Novel { NovelID = 3, Name = "Роман3"},
                new Novel { NovelID = 4, Name = "Роман4"},
                new Novel { NovelID = 5, Name = "Роман5"}
            });
            NovelController controller = new NovelController(mock.Object);
            controller.pageSize = 3;

            // Действие (act)
            IEnumerable<Novel> result = (IEnumerable<Novel>)controller.List(2).Model;

            // Утверждение (assert)
            List<Novel> novels = result.ToList();
            Assert.IsTrue(novels.Count == 2);
            Assert.AreEqual(novels[0].Name, "Роман4");
            Assert.AreEqual(novels[1].Name, "Роман5");
        }
        [TestMethod]
        public void Can_Generate_Page_Links()
        {

            // Организация - определение вспомогательного метода HTML - это необходимо
            // для применения расширяющего метода
            HtmlHelper myHelper = null;

            // Организация - создание объекта PagingInfo
            PagingInfo pagingInfo = new PagingInfo
            {
                CurrentPage = 2,
                TotalItems = 28,
                ItemsPerPage = 10
            };

            // Организация - настройка делегата с помощью лямбда-выражения
            Func<int, string> pageUrlDelegate = i => "Page" + i;

            // Действие
            MvcHtmlString result = myHelper.PageLinks(pagingInfo, pageUrlDelegate);

            // Утверждение
            Assert.AreEqual(@"<a class=""btn btn-default"" href=""Page1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Page2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Page3"">3</a>",
                result.ToString());
        }
    }
}
