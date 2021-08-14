using System;

namespace lab3
{
    [Serializable]
    public class Arr
    {
        /// <summary>
        /// source array
        /// </summary>
        public int[] mas;
        /// <summary>
        /// number boundaries
        /// </summary>
        public int A, B;
        /// <summary>
        /// constructor with size for array and number boundaries
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Arr(int n, int a, int b)
        {
            mas = new int[n];
            A = a;
            B = b;
        }
        public Arr() { }
    }
}
