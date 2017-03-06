using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {

        public string custom3;

        [TestMethod]
        public void AddOneObject()
        {


            CustomList<int> custom = new CustomList<int>();

            //Act
            custom.Add(6);
            //Assert
            Assert.AreEqual(custom[0], 6);
        }

        [TestMethod]
        public void AddMultipleObjects()
        {


            CustomList<int> custom = new CustomList<int>();

            //Act
            custom.Add(6);
            custom.Add(12);
            //Assert
            Assert.AreEqual(custom[1], 12);
        }

        [TestMethod]
        public void TestArrayExpansion()
        {

            //Arrange

            CustomList<int> custom = new CustomList<int>();

            //Act
            custom.Add(1);
            custom.Add(2);
            custom.Add(3);
            custom.Add(4);
            custom.Add(5);
            custom.Add(6);
            //Assert
            Assert.AreEqual(6, custom.Count);
        }
        [TestMethod]

        public void CheckObjectPosition()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();

            //Act
            custom.Add(6);
            custom.Add(12);
            //Assert
            Assert.AreEqual(custom[1], 12);
        }


        //If remove succeeds, decrease the count by 1.
        //If remove fails, keep count.
        //Do this inside Ienumerator Get GetEnumerator()for loop inside for loop data array [i]

        [TestMethod]
        public void RemoveOneObject()
        {

            //Arrang
            CustomList<int> custom = new CustomList<int>();
            custom.Add(6);
            custom.Add(1);
            //Act
            custom.Remove(6);
            //Assert
            Assert.AreEqual(1, custom.Count);

        }
        [TestMethod]

        public void RemoveMultipleObjects()
        {
            //Arrang

            CustomList<int> custom = new CustomList<int>();

            //Act
            custom.Add(6);
            custom.Add(12);
            custom.Remove(6);
            custom.Remove(12);
            //Assert
            Assert.AreEqual(custom.Count, 0);
        }

        [TestMethod]

        public void RemoveMultipleObjects2()
        {
            //Arrang

            CustomList<int> custom = new CustomList<int>();

            //Act
            custom.Add(6);
            custom.Add(12);
            custom.Add(18);
            custom.Remove(6);
            custom.Remove(12);
            custom.Remove(18);
            //Assert
            Assert.AreEqual(custom[0], 18);
        }


        [TestMethod]
        public void CounterChecker()
        {

            //Arrange

            CustomList<int> custom = new CustomList<int>();


            //Act

            custom.Add(1);
            custom.Add(2);

            //Assert
            Assert.AreEqual(2, custom.Count);

        }

        [TestMethod]
        public void CounterChecker2()
        {

            //Arrange

            CustomList<int> custom = new CustomList<int>();


            //Act

            custom.Add(1);
            custom.Add(2);
            custom.Add(18);
            custom.Add(6);

            //Assert
            Assert.AreEqual(4, custom.Count);

        }

        [TestMethod]
        public void CounterChecker3()
        {

            //Arrange

            CustomList<int> custom = new CustomList<int>();


            //Act

            custom.Add(1);
            custom.Add(2);
            custom.Add(3);
            custom.Add(4);
            custom.Add(20000);
            custom.Remove(1);


            //Assert
            Assert.AreEqual(custom[3], 20000);

        }

        [TestMethod]
        public void CheckIndexAfterRemoval()
        {
            CustomList<int> custom = new CustomList<int>();

            //Arrang
            custom.Add(6);
            custom.Add(17);
            custom.Add(12);
            //Act
            custom.Remove(17);

            //Assert
            Assert.AreEqual(12, custom[1]);
        }

        [TestMethod]
        public void CheckStringOverride()
        {

            //Arrange

            CustomList<int> custom = new CustomList<int>();
            custom.Add(3);
            custom.Add(4);
            custom.Add(6);

            string expected = "346";
            //Act
            string result = custom.ToString();
            //Assert
            Assert.AreEqual(result, expected);

        }



        [TestMethod]

        public void OverridePlus()
        {

            //Arrange

            CustomList<int> custom = new CustomList<int>();
            CustomList<int> custom2 = new CustomList<int>();
            CustomList<int> custom3 = new CustomList<int>();
            //Act

            custom.Add(1);
            custom2.Add(2);
            custom3 = custom + custom2;

            //Assert
            Assert.AreEqual(custom3[0], 1);

        }

        [TestMethod]
        public void CheckMinusOverride()
        {

            //Arrange

            CustomList<int> custom = new CustomList<int>();
            CustomList<int> custom2 = new CustomList<int>();
            CustomList<int> custom3 = new CustomList<int>();

            //Act

            custom.Add(1);
            custom.Add(2);
            custom2.Add(1);
            custom3 = custom - custom2;



            //Assert
            Assert.AreEqual(custom3[0], 2);

        }

        [TestMethod]
        public void CheckMinusOverride2()
        {

            //Arrange

            CustomList<int> custom = new CustomList<int>();
            CustomList<int> custom2 = new CustomList<int>();
            CustomList<int> custom3 = new CustomList<int>();


            //Act

            custom.Add(1);
            custom.Add(2);
            custom.Add(3);
            custom.Add(4);
            custom2.Add(1);
            custom2.Add(500);
            custom2.Add(3);
            custom2.Add(4);
            custom3 = custom - custom2;



            //Assert
            Assert.AreEqual(custom3[1], 4);

        }

        [TestMethod]
        public void CheckMinusOverride3()
        {

            //Arrange

            CustomList<int> custom = new CustomList<int>();
            CustomList<int> custom2 = new CustomList<int>();
            CustomList<int> custom3 = new CustomList<int>();


            //Act

            custom.Add(1);
            custom.Add(2);
            custom.Add(2);
            custom2.Add(2);
            custom3 = custom - custom2;



            //Assert
            Assert.AreEqual(custom3[1], 2);

        }


        [TestMethod]

        public void ZipTestInt()
        {

            //Arrange
            CustomList<int> even = new CustomList<int>();
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();

            //Act

            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);

            result = even.ZipList(odd);

            //Assert
            Assert.AreEqual(4, result[3]);

        }


        [TestMethod]
        public void ZipTestString()
        {

            //Arrange
            CustomList<string> even = new CustomList<string>();
            CustomList<string> odd = new CustomList<string>();
            CustomList<string> result = new CustomList<string>();


            //Act

            odd.Add("First");
            odd.Add("Third");
            even.Add("Second");
            even.Add("Fourth");

            result = even.ZipList(odd);
            //Assert
            Assert.AreEqual(result.ToString(), "FirstSecondThirdFourth");
        }

        //    [TestMethod]
        //    public void TestCustomIterate()
        //    {

        //        //Arrange
        //        CustomList<string> custom = new CustomList<string>();



        //        //Act

        //        custom.Add("1234");
        //        custom.Add("5678");
        //        custom.Add("910 ");
        //        custom.Add("Testing is worse than being waterboarded");

        //        foreach (string value in custom)
        //        {
        //            //result.Add(value)
        //        }
        //        //Assert
        //        Assert.AreEqual(result, "First Second Third Fourth");
        //    }
        //} }






    }
    }