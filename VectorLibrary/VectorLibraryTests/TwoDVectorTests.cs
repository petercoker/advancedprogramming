using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorLibrary;

namespace VectorLibraryTests
{
    /*
     * Attributes are used to identify classes and functions
     * that are part of unit testing.
     * The [TestClass] attribute is required by the framework so that the Test
     * Explorer can identify those classes that potentially have
     * test methods defined.
     */
    [TestClass]
    public class TwoDVectorTests
    {
        /*
         * Each test we want the Test Explorer to run requires
         * [TestMethod] attribute.
         * Caveat - MS Unit test methods can't return anything 
         * (they all have a void return type); 
         * they can't take any parameters, so argument lists are 
         * always empty.
         */ 
        [TestMethod]
        public void Adding1By1VectorTo2By3VectorGives3By4Vector()
        {
            /*
             * Unit testing under TDD follows a well defined
             * implementation pattern known as the 3 A's of 
             * unit testing.
             *  - Arrange Act Assert
             *  
             *  Arrange  - set up the test and test conditions of the 
             *  SUT (create all objects, parameters, resources.
             */ 
            TwoDVector vec1x1 = new TwoDVector(1F, 1F);
            TwoDVector vec2x3 = new TwoDVector(2F, 3F);

            /*
             * Act - this means to invoke the behaviour/functionality
             * we are testing
             */
            TwoDVector vec3x4 = vec1x1 + vec2x3;

            /*
             * Assert - means checking that the behaviour or functionality
             * we are testing produces the desired result.
             * 
             */
            Assert.AreEqual(3, vec3x4.I);
            Assert.AreEqual(4, vec3x4.J); 
        }

        /*
         * The following test acts to corroborate the test
         * above.  We do this as we are using Fake it till you
         * make it pattern.  The idea is that the literal/constant
         * that we hard-coded in the implementation gets the above
         * test to the green state ASAP. It gives us reassurance
         * that the test works.
         */
        [TestMethod]
        public void ZeroVectorPlus1By1VectorGives1By1Vector()
        {
            // Arrange
            TwoDVector zeroVector = new TwoDVector(0, 0);
            TwoDVector vec1By1 = new TwoDVector(1, 1);

            // Act
            TwoDVector identity = zeroVector + vec1By1;

            // Assert
            Assert.AreEqual(vec1By1.I, identity.I);
            Assert.AreEqual(vec1By1.J, identity.J);
        }
    }

    [TestClass]
    public class TwoDVectorTestss
    {
        /*
         * Each test we want the Test Explorer to run requires
         * [TestMethod] attribute.
         * Caveat - MS Unit test methods can't return anything 
         * (they all have a void return type); 
         * they can't take any parameters, so argument lists are 
         * always empty.
         */
        [TestMethod]
        public void Adding3By3VectorTo2By3VectorGives3By4Vector()
        {
            TwoDVector vec3x3 = new TwoDVector(3F, 3F);
            TwoDVector vec6x2 = new TwoDVector(6F, 2f);
            TwoDVector vec3x9;

            /*
             * Act - this means to invoke the behaviour/functionality
             * we are testing
             */
            TwoDVector vec3x3 = vec1x1 + vec2x3;

            /*
             * Assert - means checking that the behaviour or functionality
             * we are testing produces the desired result.
             * 
             */
            Assert.AreEqual(3, vec3x3.I);
            Assert.AreEqual(4, vec3x3.J);
        }

        /*
         * The following test acts to corroborate the test
         * above.  We do this as we are using Fake it till you
         * make it pattern.  The idea is that the literal/constant
         * that we hard-coded in the implementation gets the above
         * test to the green state ASAP. It gives us reassurance
         * that the test works.
         */
        [TestMethod]
        public void ZeroVectorPlus1By1VectorGives1By1Vector()
        {
            // Arrange
            TwoDVector zeroVector = new TwoDVector(0, 0);
            TwoDVector vec1By1 = new TwoDVector(1, 1);

            // Act
            TwoDVector identity = zeroVector + vec1By1;

            // Assert
            Assert.AreEqual(vec1By1.I, identity.I);
            Assert.AreEqual(vec1By1.J, identity.J);
        }
    }
}
