using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wc3HeroPicker.Library.Data;

namespace Wc3HeroPicker.Tests
{
    [TestClass]
    public class ConnectorTests
    {
        private Connector connector;

        [TestInitialize]
        public void Init()
        {
            connector = new Connector();
        }

        [TestMethod]
        public async Task UpsertHero_HeroMitNeuemNamen_HeroPersistiert()
        {
            //Arrange
            var expectedName = "Brolaf";

            //Act
            await connector.InsertHero(expectedName);
            var result = await connector.GetHeroByName(expectedName);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedName, result.Name);
        }
    }
}
