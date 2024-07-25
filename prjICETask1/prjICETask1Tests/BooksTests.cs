using Microsoft.VisualStudio.TestTools.UnitTesting;
using prjICETask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICETask1.Tests
{
    [TestClass()]
    public class BooksTests
    {
        [TestMethod()]
        public void BooksTest()
        {
            Books emp = new Books(1, "Adventures of Amber's love life", "Amber Boucher", 600);

            double expected = 1;
            double result = Convert.ToDouble(emp[0]);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void BooksTest1()
        {
            Books emp = new Books(2, "Kelly's OCD", "Kelly Botha", 200);

            double expected = 2;
            double result = Convert.ToDouble(emp[0]);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void BooksTest2()
        {
            Books emp = new Books(3, "Helga's Confusion", "Helga Mboni", 350);

            double expected = 3;
            double result = Convert.ToDouble(emp[0]);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void BooksTest3()
        {
            Books emp = new Books(4, "George's lost braincells", "George Bekker", 750);

            double expected = 4;
            double result = Convert.ToDouble(emp[0]);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void BooksTest4()
        {
            Books emp = new Books(5, "The IDK Chronicles", "I D. Know", 275);

            double expected = 5;
            double result = Convert.ToDouble(emp[0]);
            Assert.AreEqual(expected, result);
        }

    }
}