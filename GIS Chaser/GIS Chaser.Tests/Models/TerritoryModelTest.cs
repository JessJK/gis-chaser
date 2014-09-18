using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GIS_Chaser.Tests.Models
{
    [TestClass]
    public class TerritoryModelTest
    {
        [TestMethod]
        public void A_users_id_is_assigned_to_area_cell()
        {
            //Arrange
            var area = new object();
            var expected = "user";

            //Act
            //user id assigned to area

            //Assert
            Assert.AreEqual(area, expected);
        }
    }
}
