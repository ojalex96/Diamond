using Diamond;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamondTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_If_A_Is_True()
        {
            List<string> diamond = new List<string>();
            diamond.Add("A");
            Assert.IsTrue(diamond.SequenceEqual(Program.DisplayDiamond('A')));
        }


        [TestMethod]
        public void Test_If_D_is_Middle()
        {
            List<string> diamond = new List<string>();
            StringBuilder testString = new StringBuilder();
            testString.Append("   A   ");
            testString.Append("  B B  ");
            testString.Append(" C   C ");
            testString.Append("D     D");
            testString.Append(" C   C ");
            testString.Append("  B B  ");
            testString.Append("   A   ");
            StringBuilder returnString = new StringBuilder();
            diamond = Program.DisplayDiamond('D');
            foreach(var item in diamond)
            {
                returnString.Append(item);
            }
            StringAssert.Equals(testString, returnString);
        }


        [TestMethod]
        public void Test_If_Objects_Are_Same_For_C()
        {
            List<string> diamond = new List<string>();
            diamond.Add("  A  ");
            diamond.Add(" B B ");
            diamond.Add("C   C");
            diamond.Add(" B B ");
            diamond.Add("  A  ");
            CollectionAssert.AreEqual(diamond, Program.DisplayDiamond('C'));
        }

        [TestMethod]
        public void Test_If_Last_Item_is_equal()
        {
            string lastItem = "                         A                         ";
            List<string> returnedString = Program.DisplayDiamond('Z');
            Assert.AreEqual(lastItem, returnedString[returnedString.Count-1]);
        }

        [TestMethod]
        public void Test_If_are_equal_with_lowercase_Char()
        {
            List<string> diamond = new List<string>();
            diamond.Add("  A  ");
            diamond.Add(" B B ");
            diamond.Add("C   C");
            diamond.Add(" B B ");
            diamond.Add("  A  ");
            CollectionAssert.AreEqual(diamond, Program.DisplayDiamond('c'));
        }
    }
}
