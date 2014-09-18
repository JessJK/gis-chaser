using System;
using System.Collections.Generic;
using System.Linq;
using GIS_Chaser.Models;
using GIS_Chaser.ScheduledTasks;
using GIS_Chaser.Tests.FakePlumbing;
using Microsoft.Ajax.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GIS_Chaser.Tests.Models
{
    [TestClass]
    public class GemModelTest
    {
        [TestMethod]
        public void There_will_be_more_than_one_type_of_gem()
        {

            //arrange

            List<string> gemList = new List<string>();

            //act
            
            foreach (GemTypesEnum.GemTypes gemtypes in (GemTypesEnum.GemTypes[]) Enum.GetValues(typeof(GemTypesEnum.GemTypes)))
            {
                gemList.Add(gemtypes.ToString());
            }
            var actual = gemList.Count;

            //assert

            Assert.IsTrue(actual > 1);
        }

        [TestMethod]
        public void Some_gems_will_be_more_valuable_than_others()
        {

            //arrange

            List<int> gemValueList = new List<int>();

            //act

            foreach (GemTypesEnum.GemTypes gemtypes in (GemTypesEnum.GemTypes[])Enum.GetValues(typeof(GemTypesEnum.GemTypes)))
            {
                gemValueList.Add((int)gemtypes);
            }
            int countOfList = gemValueList.Count;
            int valueOfList = gemValueList.Sum();

            //assert

            Assert.IsTrue(valueOfList > countOfList);
        }

        [TestMethod]
        public void A_Gem_is_Created_with_expected_properties()
        {
            //arrange
            GemModel userModel = new GemModel(new GemsPlumbingFake());
            var expected = GemTypesEnum.GemTypes.Gold;

            //act
            var gem = userModel.AssembleGem(1, 5, 41.122, 41.522);

            //assert
            Assert.AreEqual(gem.PointsValue, 5);
            Assert.AreEqual(gem.Type, (int)expected);
            Assert.AreEqual(gem.Latitude, 41.122);
            Assert.AreEqual(gem.Longitude, 41.522);
        }
    }
}
