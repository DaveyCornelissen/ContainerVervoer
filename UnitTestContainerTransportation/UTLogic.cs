using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainerTransport;

namespace UnitTestContainerTransportation
{
    [TestClass]
    public class UTLogic
    {
        private Logic TestLogic;
        private List<Container> testContainers = new List<Container>();

        [TestInitialize]
        public void initialize()
        {
            TestLogic = new Logic(1200000);

//            //add value
//            for (int i = 0; i < 4; i++)
//            {
//                Container testContainer = new Container
//                {
//                    Weight = 30000,
//                    Standard = false,
//                    Valuable = true,
//                    Cooled = false
//                };
//
//                testContainers.Add(testContainer);
//            }
//
//            //add cooled
//            for (int i = 0; i < 4; i++)
//            {
//                Container testContainer = new Container
//                {
//                    Weight = 30000,
//                    Standard = false,
//                    Valuable = false,
//                    Cooled = true
//                };
//
//                testContainers.Add(testContainer);
//            }

        }

        //test if minimum weight is matched
        [TestMethod]
        public void checkMinimumWeight()
        {
            try
            {
                //add default
                for (int i = 0; i < 5; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = true;
                    bool Valuable = false;
                    bool Cooled = false;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }

                TestLogic.StartAlgoritem();
            }
            catch (ExceptionHandler e)
            {
                string expectedString = String.Format("The total docked containers weight do not require the minimum ship weight of {0}! other wise the ship will capsize!", TestLogic.ship.MinWeight);
                Assert.AreEqual(expectedString, e.Message);
            }
        }

        //test if minimum weight is matched
        [TestMethod]
        public void checkMaximiumWeight()
        {
            try
            {
                //add default
                for (int i = 0; i < 45; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = true;
                    bool Valuable = false;
                    bool Cooled = false;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }

                TestLogic.StartAlgoritem();
            }
            catch (ExceptionHandler e)
            {
                string expectedString = String.Format("The total docked containers weight is higher than the maximum ship weight of {0} other wise it will capsize!", TestLogic.ship.MaxWeight);
                Assert.AreEqual(expectedString, e.Message);
            }
        }
    }
}
