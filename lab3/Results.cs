using System;

namespace lab3
{
    [Serializable]
    public class Results
    {
        /// <summary>
        /// result array
        /// </summary>
        public int[] sort_array;
        /// <summary>
        /// sum and quantity numbers greater than C with even index
        /// </summary>
        public int[] sum_quntity_greater_C;
        /// <summary>
        /// sum and quantity of elements of array, for which the number, composed of the last two digits, is divisible by 3
        /// </summary>
        public int[] sum_quntity_divisible_3;
        /// <summary>
        /// sum and quantity of elements of array, for which the number, composed of the last two digits, is divisible by 5
        /// </summary>
        public int[] sum_quntity_divisible_5;
        /// <summary>
        /// constructor with size for arrays
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public Results(int n, int m)
        {
            sort_array = new int[n];
            sum_quntity_greater_C = new int[m];
            sum_quntity_divisible_3 = new int[m];
            sum_quntity_divisible_5 = new int[m];
        }
        public Results() { }
    }
}
