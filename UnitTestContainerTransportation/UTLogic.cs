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
        private int _totalValuable;
        private int _totalCooled;

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

        //test if maximum weight is matched
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

        //test if maximum valuable containers is matched
        [TestMethod]
        public void checkMaximiumValuable()
        {
            try
            {
                //add valuable
                for (int i = 0; i < 5; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = false;
                    bool Valuable = true;
                    bool Cooled = false;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }

                //add default
                for (int i = 0; i < 35; i++)
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
                //check totalValuable containers
                _totalValuable = TestLogic.DockedContainers.FindAll(c => c.Valuable).Count;
                string expectedString = String.Format("There are to many valuable containers! There are current {0} and there are only 4 allowed on this ship",
                    _totalValuable);
                Assert.AreEqual(expectedString, e.Message);
            }
        }

        //test if maximum cooled containers is matched
        [TestMethod]
        public void checkMaximiumCooled()
        {
            try
            {
                //add cooled
                for (int i = 0; i < 10; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = false;
                    bool Valuable = false;
                    bool Cooled = true;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }

                //add valuable
                for (int i = 0; i < 4; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = false;
                    bool Valuable = true;
                    bool Cooled = false;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }

                //add default
                for (int i = 0; i < 15; i++)
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
                //Check totalCooled containers
                _totalCooled = TestLogic.DockedContainers.FindAll(c => c.Cooled).Count;
                //check totalValuable containers
                _totalValuable = TestLogic.DockedContainers.FindAll(c => c.Valuable).Count;
                string expectedString = String.Format("There are to many cooled containers! There are current {0} and you can only have at max 10 if there are no valuable containers. the total valuable containers are {1}",
                    _totalCooled, _totalValuable);
                Assert.AreEqual(expectedString, e.Message);
            }
        }
    }
}
