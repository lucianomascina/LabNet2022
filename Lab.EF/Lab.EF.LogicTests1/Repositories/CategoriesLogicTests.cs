using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.EF.Entities;
using Moq;
using System.Data.Entity;
using Lab.EF.Data;

namespace Lab.EF.Logic.Tests
{
    [TestClass()]
    public class CategoriesLogicTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            var data = new List<Categories>
            {
                new Categories { CategoryName = "calzado"},
                new Categories { CategoryName = "indumentaria"},
                new Categories { CategoryName = "electrodomesticos"},
            }.AsQueryable();

            var mockset = new Mock<DbSet<Categories>>();
            mockset.As<IQueryable<Categories>>().Setup(m => m.Provider).Returns(data.Provider);
            mockset.As<IQueryable<Categories>>().Setup(m => m.Expression).Returns(data.Expression);
            mockset.As<IQueryable<Categories>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockset.As<IQueryable<Categories>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(c => c.Categories).Returns(mockset.Object);

            var service = new CategoriesLogic(mockContext.Object);
            var categories = service.GetAll();

            Assert.AreEqual(3, categories.Count);
            Assert.AreEqual("calzado",categories[0].CategoryName);
            Assert.AreEqual("indumentaria", categories[1].CategoryName);
            Assert.AreEqual("electrodomesticos", categories[2].CategoryName);

        }

        [TestMethod]
        public void AddTest()
        {
            var mockSet = new Mock<DbSet<Categories>>();

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Categories).Returns(mockSet.Object);

            CategoriesLogic categoriesLogic = new CategoriesLogic(mockContext.Object);

            categoriesLogic.Add(new Categories
            {
                CategoryName ="calzado",
                Description ="zapatillas y botines",
                
            });

            mockSet.Verify(m => m.Add(It.IsAny<Categories>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}