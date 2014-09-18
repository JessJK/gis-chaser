using System;
using System.Collections.Generic;
using System.Linq;
using GIS_Chaser.Models;
using GIS_Chaser.ScheduledTasks;
using GIS_Chaser.Tests.FakePlumbing;
using GIS_Chaser.Tests.FakeSchedule;
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
            
            foreach (GemTypeModel.GemTypes gemtypes in (GemTypeModel.GemTypes[]) Enum.GetValues(typeof(GemTypeModel.GemTypes)))
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

            foreach (GemTypeModel.GemTypes gemtypes in (GemTypeModel.GemTypes[])Enum.GetValues(typeof(GemTypeModel.GemTypes)))
            {
                gemValueList.Add((int)gemtypes);
            }
            int countOfList = gemValueList.Count;
            int valueOfList = gemValueList.Sum();

            //assert

            Assert.IsTrue(valueOfList > countOfList);
        }
        [TestMethod]
        public void A_Gem_is_created_more_than_once()
        {
            //arrange
            GemModel userModel = new GemModel(new GemsPlumbingFake(), new GemScheduleAddFake());

            //act
            userModel.AutoAddGem();
            var gems = userModel.GetGems();

            //assert
            Assert.AreEqual();
            //assert that the number of gems in the fake db is 10(arbitary number)

        }

    }
}
