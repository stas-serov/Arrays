using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace lab3
{
    public class Operations
    {
        /// <summary>
        /// source array and number boundaries
        /// </summary>
        public Arr array;
        /// <summary>
        /// results
        /// </summary>
        public Results results;
        public void generate_array(int n, int a, int b)
        {
            array = new Arr(n, a, b);
            results = new Results(n, 2);
            Random rd = new Random();
            for (int i = 0; i < n; i++)
                array.mas[i] = rd.Next(a, b);
        }
        /// <summary>
        /// method for saving array
        /// </summary>
        /// <returns></returns>
        public bool save_array()
        {
            bool res = false;
            string fname = "";
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save file";
            save.InitialDirectory = @"C:\Users\STAS\source\repos\lab3";
            if (save.ShowDialog() == DialogResult.OK)
            {
                fname = save.FileName;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Arr));
                    using (FileStream fs = new FileStream(fname, FileMode.Open))
                    {
                        serializer.Serialize(fs, array);
                    }
                    res = true;
                }
                catch
                {

                    res = false;
                }
            }
            return res;
        }
        /// <summary>
        /// method for reading array
        /// </summary>
        /// <returns></returns>
        public bool read_array()
        {
            bool res = false;
            string fname = "";
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open file";
            open.InitialDirectory = @"C:\Users\STAS\source\repos\lab3";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fname = open.FileName;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Arr));
                    using (FileStream fs = new FileStream(fname, FileMode.Open))
                    {
                        array = (Arr)serializer.Deserialize(fs);
                    }
                    res = true;
                }
                catch
                {
                    res = false;
                }
            }
            return res;
        }
        /// <summary>
        /// method for saving results
        /// </summary>
        /// <returns></returns>
        public bool save_results()
        {
            bool res = false;
            string fname = "F_2.xml";
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save file";
            if (save.ShowDialog() == DialogResult.OK)
            {
                fname = save.FileName;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Results));
                    using (FileStream fs = new FileStream(fname, FileMode.Open))
                    {
                        serializer.Serialize(fs, results);
                    }
                    res = true;
                }
                catch
                {
                    res = false;
                }
            }
            return res;
        }
        /// <summary>
        /// method for first operation
        /// </summary>
        public void operation1()
        {
            results.sort_array = array.mas.OrderByDescending(i => i).ToArray();
        }
        /// <summary>
        /// method for second operation
        /// </summary>
        /// <param name="c"></param>
        public void operation2(int c)
        {
            int sum = 0, n = 0;
            for (int i = 0; i < array.mas.Length; i++)
            {
                if ((array.mas[i] > c) && (i % 2 == 0))
                {
                    sum += array.mas[i];
                    n++;
                }
            }
            results.sum_quntity_greater_C[0] = sum;
            results.sum_quntity_greater_C[1] = n;
        }
        /// <summary>
        /// method for third operation
        /// </summary>
        public void operation3()
        {
            int sum = 0, n = 0;
            for (int i = 0; i < array.mas.Length; i++)
            {
                int str = array.mas[i];
                if ((str % 10 + (str / 10) % 10) % 3 == 0)
                {
                    sum += array.mas[i];
                    n++;
                }
            }
            results.sum_quntity_divisible_3[0] = sum;
            results.sum_quntity_divisible_3[1] = n;
        }
        /// <summary>
        /// method for fourth operation
        /// </summary>
        public void operation4()
        {
            int sum = 0, n = 0;
            for (int i = 0; i < array.mas.Length; i++)
            {
                int str = array.mas[i];
                if ((str % 10 + (str / 10) % 10) % 5 == 0)
                {
                    sum += array.mas[i];
                    n++;
                }
            }
            results.sum_quntity_divisible_5[0] = sum;
            results.sum_quntity_divisible_5[1] = n;
        }
    }
}
