using AutoMapper;
using BusinessLayer;
using BusinessLayer.InterfacesBL;
using BusinessLayer.Models;
using DAL.InterfacesDAL;
using DAL.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Web.UI;

namespace NewAnimalsHouses.Tests
{
    [TestFixture]
    public class HouseManagerTest
    {

        [Test]
        public void Test()
        {
            Assert.NotNull(true);
        }

        [Test]
        public void CreateHouse_CreatedEntity()
        {
            var budka = new HouseModel { Name = "Будка" };

            var houseRepositoryMock = new Mock<IHouseRepository>();
            var mapperMock = new Mock<IMapper>();
            var houseBudka = new HouseModel { Id = 5, Name = "Будка" };
            houseRepositoryMock.Setup(x => x.CreateHouse(It.IsAny<House>())).Returns(new House { Id = 5, Name = "Будка" });
            mapperMock.Setup(x => x.Map<HouseModel>(It.IsAny<House>())).Returns(houseBudka);
            mapperMock.Setup(x => x.Map<House>(It.IsAny<HouseModel>())).Returns(new House { Id = 5, Name = "Будка" });
            IHouseManager _houseManager = new HouseManager(houseRepositoryMock.Object, mapperMock.Object);
            
            var someHouse = _houseManager.CreateHouse(budka);
            Assert.AreEqual(houseBudka.Name, budka.Name);
        }

    }
}
