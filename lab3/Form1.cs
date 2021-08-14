using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        Operations op = new Operations();
        public Form1()
        {
            InitializeComponent();
            save_array.Enabled = false;
            read_array.Enabled = false;
            save_results.Enabled = false;
            operation1.Enabled = false;
            operation2.Enabled = false;
            operation3.Enabled = false;
            operation4.Enabled = false;
            numericUpDown_c.Enabled = false;
        }
        /// <summary>
        /// method for loading form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(operation1, "Sorting the elements of the array in descending order");
            tip.SetToolTip(operation2, "Determine the sum and quantity of numbers greater than C with even numbers");
            tip.SetToolTip(operation3, "Determine the sum and number of array elements, for which the number,composed of the last two digits of a number, is divisible by 3");
            tip.SetToolTip(operation4, "Determine the sum and number of array elements, for which the number, composed of the last two digits of a number, is divisible by 5");
        }
        /// <summary>
        /// button for generating array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generate_array_Click(object sender, EventArgs e)
        {
            if ((numericUpDown_size.Value == 0) || (numericUpDown_a.Value < -2000) || (numericUpDown_b.Value > 4000))
            {
                MessageBox.Show("Wrong input data!", "Error!");
            }
            else
            {
                textBox_array.Clear();
                op.generate_array((int)numericUpDown_size.Value, (int)numericUpDown_a.Value, (int)numericUpDown_b.Value);
                MessageBox.Show("Array was create", "Message");
                for (int i = 0; i < op.array.mas.Length; i++)
                    textBox_array.Text = textBox_array.Text + "  " + op.array.mas[i].ToString();
                dgv.Rows.Clear();
                dgv.ReadOnly = true;
                dgv.ColumnCount = 2;
                dgv.RowCount = (int)numericUpDown_size.Value;
                for (int i = 0; i < dgv.ColumnCount; i++)
                    dgv.Columns[i].Width = 90;
                dgv.Columns[0].HeaderText = "index";
                dgv.Columns[1].HeaderText = "element";
                dgv.RowHeadersVisible = false;
                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    dgv[0, i].Value = i;
                    dgv[1, i].Value = op.array.mas[i];
                }
                numericUpDown_c.Enabled = true;
                save_array.Enabled = true;
                operation1.Enabled = true;
                operation2.Enabled = true;
                operation3.Enabled = true;
                operation4.Enabled = true;
            }
        }
        /// <summary>
        /// button for saving array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_array_Click(object sender, EventArgs e)
        {
            bool result = op.save_array();
            if (result)
            {
                MessageBox.Show("Array was saved", "Message");
                read_array.Enabled = true;
            }
            else MessageBox.Show("Array wasn't saved. Please, check input data and try again", "Error!");
        }
        /// <summary>
        /// button for reading array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void read_array_Click(object sender, EventArgs e)
        {
            bool result = op.read_array();
            if (result)
            {
                MessageBox.Show("Array was read", "Message");
            }
            else MessageBox.Show("Array wasn't read. Please, check input data and try again", "Error!");
        }
        /// <summary>
        /// button for saving results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_results_Click(object sender, EventArgs e)
        {
            bool result = op.save_results();
            if (result)
            {
                MessageBox.Show("Results were saved", "Message");
            }
            else MessageBox.Show("Results weren't saved. Please, check input data and try again", "Error!");
        }
        /// <summary>
        /// button for fist operation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operation1_Click(object sender, EventArgs e)
        {
            op.operation1();
            textBox_result1.Clear();
            for (int i = 0; i < op.results.sort_array.Length; i++)
            {
                textBox_result1.Text += " " + op.results.sort_array[i].ToString();
            }
            save_results.Enabled = true;
        }
        /// <summary>
        /// button for second operation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operation2_Click(object sender, EventArgs e)
        {
            op.operation2((int)numericUpDown_c.Value);
            textBox_result2.Text = "sum:" + op.results.sum_quntity_greater_C[0].ToString() + "  " + "n:" + op.results.sum_quntity_greater_C[1].ToString();
            save_results.Enabled = true;
        }
        /// <summary>
        /// button for third operation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operation3_Click(object sender, EventArgs e)
        {
            op.operation3();
            textBox_result3.Text = "sum:" + op.results.sum_quntity_divisible_3[0].ToString() + "  " + "n:" + op.results.sum_quntity_divisible_3[1].ToString();
            save_results.Enabled = true;
        }
        /// <summary>
        /// button for fourth operation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operation4_Click(object sender, EventArgs e)
        {
            op.operation4();
            textBox_result4.Text = "sum:" + op.results.sum_quntity_divisible_5[0].ToString() + "  " + "n:" + op.results.sum_quntity_divisible_5[1].ToString();
            save_results.Enabled = true;
        }
    }
}
