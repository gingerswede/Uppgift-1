using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TriangelUnitTest
    {
        /*** Testing Scalene ****************************************
        **** [ Scalene => Triangeln har inga lika sidor] ************/

        [TestMethod]
        public void IsScalene_EvrySideLength1()
        {
            // remark: orgnial code did not pass test 
            Triangle tri = new Triangle(1.0, 1.0, 1.0);    
            Assert.IsFalse( tri.isScalene() ); 
        }
        [TestMethod]
        public void IsScalene_2EqualSides()
        {
            Triangle tri = new Triangle(1.0, 1.0, 2.0);
            Assert.IsFalse(tri.isScalene()); 
        }
        [TestMethod]
        public void IsScalene_3DiffrentLengths()
        {
            // remark: orgnial code did not pass test 
            Triangle tri = new Triangle(3.0, 4.0, 5.0);
            Assert.IsTrue(tri.isScalene());
        }


        /*** Testing isEquilateral ****************************************
        **** [ Equilateral : liksidig ] ***********************************/

        [TestMethod]
        public void isEquilateral_3EvrySideLength1()
        {
            // remark: orgnial code did not pass test 
            Triangle tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(tri.isEquilateral());
        }
        [TestMethod]
        public void isEquilateral_2EqualSides()
        {
            // remark: orgnial code did not pass test 
            Triangle tri = new Triangle(1.0, 1.0, 2.0);
            Assert.IsFalse(tri.isEquilateral());
        }
        [TestMethod]
        public void isEquilateral_3DiffrentLengths()
        {
            Triangle tri = new Triangle(3.0, 4.0, 5.0);
            Assert.IsFalse(tri.isEquilateral());
        }


        /*** Testing isEquilateral ****************************************
        **** [ Isosceles : likbent ] **************************************/

        [TestMethod]
        public void isIsosceles_3EvrySideLength1()
        {
            Triangle tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsFalse(tri.isIsosceles());
        }
        [TestMethod]
        public void isIsosceles_2EqualSides()
        {
            // test did not pass orgnial Code
            Triangle tri = new Triangle(1.0, 1.0, 2.0);
            Assert.IsTrue(tri.isIsosceles());
        }
        [TestMethod]
        public void isIsosceles_3DiffrentLengths()
        {
            Triangle tri = new Triangle(3.0, 4.0, 5.0);
            Assert.IsFalse(tri.isIsosceles());
        }

        /*** Testing Constructors ***********************************/

        [TestMethod]
        public void constructor_PointArray()
        {
            Point[] point = new Point[3];
            point[0] = new Point(0, 0); // this triangle should be Isosceles
            point[1] = new Point(0, 1);
            point[2] = new Point(1, 1);
            Triangle tri = new Triangle(point);
            Assert.IsTrue(tri.isIsosceles());
            Assert.IsFalse(tri.isScalene()); 
            Assert.IsFalse(tri.isEquilateral());
        }

        public void constructor_3Points()
        {
            Point[] point = new Point[3];
            point[0] = new Point(0, 0); // this triangle should be Isosceles
            point[1] = new Point(0, 1);
            point[2] = new Point(1, 1);
            Triangle tri = new Triangle(point[0], point[1], point[2]);
            Assert.IsTrue(tri.isIsosceles());
            Assert.IsFalse(tri.isScalene());
            Assert.IsFalse(tri.isEquilateral());
        }
    }
}
