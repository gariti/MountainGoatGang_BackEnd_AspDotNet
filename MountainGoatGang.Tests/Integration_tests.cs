using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MountainGoatGang.Repository;

namespace MountainGoatGang.Tests
{
    [TestClass]
    public class Integration_tests
    {
        [TestMethod]
        public void AddGroup()
        {
            //Arrange
            var context = new MountainGoatGangContext();
            var repo = new MountainGoatGangRepository(context);
            Group group = new Group()
            {
                Name = "MountainGoatGang",
                Description = "The first Mountain Goat Gang group!!",
                Id = 1
            };

            //Act
            repo.AddGroup(group);

            //Assert


        }
    }
}
