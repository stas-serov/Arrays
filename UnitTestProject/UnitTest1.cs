using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Operations op = new Operations();
        [TestMethod]
        public void array_descending()
        {
            op.array = new Arr(5, -2000, 4000);
            op.results = new Results(5, 2);
            op.array.mas = new int[] { -355, 543, 242, 3655, -686 };
            op.operation1();
            int[] expected = new int[] { 3655, 543, 242, -355, -686 };
            int[] actual = op.results.sort_array;
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void sum_quantity_greater_C()
        {
            op.array = new Arr(5, -2000, 4000);
            op.results = new Results(5, 2);
            op.array.mas = new int[] { -355, 543, 242, 3655, 555 };
            op.operation2(100);
            int[] expected = new int[] { 797, 2 };
            int[] actual = op.results.sum_quntity_greater_C;
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void sum_quantity_devisible_3()
        {
            op.array = new Arr(5, -2000, 4000);
            op.results = new Results(5, 2);
            op.array.mas = new int[] { -355, 543, 242, 3655, 554 };
            op.operation3();
            int[] expected = new int[] { 796, 2 };
            int[] actual = op.results.sum_quntity_divisible_3;
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void sum_quantity_devisible_5()
        {
            op.array = new Arr(5, -2000, 4000);
            op.results = new Results(5, 2);
            op.array.mas = new int[] { -355, 543, 242, 3655, 554 };
            op.operation4();
            int[] expected = new int[] { 3300, 2 };
            int[] actual = op.results.sum_quntity_divisible_5;
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
