using System;
using GIS_Chaser.Controllers;
using GIS_Chaser.Plumbing.TableInterfaces;
using GIS_Chaser.Plumbing.TablePlumbings;
using GIS_Chaser.Tests.FakePlumbing;
using GIS_Chaser.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GIS_Chaser.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void Test_that_Get_Points_by_given_user_id_is_as_expected()
        {
            //Arrange
            UserController userController = new UserController(new ExtendUserTablePlumbingFake());

            //Act
            int actual = userController.Get("user");

            //Assert
            Assert.AreEqual(actual, 5);

        }
    }
}
