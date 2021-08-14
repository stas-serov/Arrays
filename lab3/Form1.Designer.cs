
namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.generate_array = new System.Windows.Forms.Button();
            this.save_array = new System.Windows.Forms.Button();
            this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_b = new System.Windows.Forms.NumericUpDown();
            this.label_size = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.textBox_array = new System.Windows.Forms.TextBox();
            this.label_array = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.read_array = new System.Windows.Forms.Button();
            this.save_results = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.operation2 = new System.Windows.Forms.Button();
            this.operation4 = new System.Windows.Forms.Button();
            this.operation1 = new System.Windows.Forms.Button();
            this.operation3 = new System.Windows.Forms.Button();
            this.label_C = new System.Windows.Forms.Label();
            this.numericUpDown_c = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_result1 = new System.Windows.Forms.TextBox();
            this.textBox_result2 = new System.Windows.Forms.TextBox();
            this.textBox_result3 = new System.Windows.Forms.TextBox();
            this.textBox_result4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_c)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Enabled = false;
            this.dgv.Location = new System.Drawing.Point(33, 123);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(176, 223);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(97, 96);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Array";
            // 
            // generate_array
            // 
            this.generate_array.BackColor = System.Drawing.Color.Coral;
            this.generate_array.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.generate_array.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generate_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generate_array.Location = new System.Drawing.Point(6, 25);
            this.generate_array.Name = "generate_array";
            this.generate_array.Size = new System.Drawing.Size(116, 27);
            this.generate_array.TabIndex = 2;
            this.generate_array.Text = "Generate array";
            this.generate_array.UseVisualStyleBackColor = false;
            this.generate_array.Click += new System.EventHandler(this.generate_array_Click);
            // 
            // save_array
            // 
            this.save_array.BackColor = System.Drawing.Color.Coral;
            this.save_array.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_array.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_array.Location = new System.Drawing.Point(6, 68);
            this.save_array.Name = "save_array";
            this.save_array.Size = new System.Drawing.Size(116, 27);
            this.save_array.TabIndex = 3;
            this.save_array.Text = "Save array";
            this.save_array.UseVisualStyleBackColor = false;
            this.save_array.Click += new System.EventHandler(this.save_array_Click);
            // 
            // numericUpDown_size
            // 
            this.numericUpDown_size.Location = new System.Drawing.Point(73, 12);
            this.numericUpDown_size.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_size.Name = "numericUpDown_size";
            this.numericUpDown_size.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown_size.TabIndex = 4;
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Location = new System.Drawing.Point(200, 12);
            this.numericUpDown_a.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown_a.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown_a.TabIndex = 5;
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.Location = new System.Drawing.Point(330, 12);
            this.numericUpDown_b.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown_b.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDown_b.Name = "numericUpDown_b";
            this.numericUpDown_b.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown_b.TabIndex = 6;
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_size.Location = new System.Drawing.Point(26, 12);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(41, 20);
            this.label_size.TabIndex = 7;
            this.label_size.Text = "size:";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_A.Location = new System.Drawing.Point(170, 12);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(24, 20);
            this.label_A.TabIndex = 8;
            this.label_A.Text = "A:";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_B.Location = new System.Drawing.Point(300, 12);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(24, 20);
            this.label_B.TabIndex = 9;
            this.label_B.Text = "B:";
            // 
            // textBox_array
            // 
            this.textBox_array.Enabled = false;
            this.textBox_array.Location = new System.Drawing.Point(73, 63);
            this.textBox_array.Name = "textBox_array";
            this.textBox_array.Size = new System.Drawing.Size(466, 20);
            this.textBox_array.TabIndex = 10;
            // 
            // label_array
            // 
            this.label_array.AutoSize = true;
            this.label_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_array.Location = new System.Drawing.Point(19, 63);
            this.label_array.Name = "label_array";
            this.label_array.Size = new System.Drawing.Size(48, 20);
            this.label_array.TabIndex = 11;
            this.label_array.Text = "array:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.read_array);
            this.groupBox1.Controls.Add(this.save_results);
            this.groupBox1.Controls.Add(this.generate_array);
            this.groupBox1.Controls.Add(this.save_array);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(237, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // read_array
            // 
            this.read_array.BackColor = System.Drawing.Color.Coral;
            this.read_array.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.read_array.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.read_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.read_array.Location = new System.Drawing.Point(6, 111);
            this.read_array.Name = "read_array";
            this.read_array.Size = new System.Drawing.Size(116, 27);
            this.read_array.TabIndex = 14;
            this.read_array.Text = "Read array";
            this.read_array.UseVisualStyleBackColor = false;
            this.read_array.Click += new System.EventHandler(this.read_array_Click);
            // 
            // save_results
            // 
            this.save_results.BackColor = System.Drawing.Color.Coral;
            this.save_results.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_results.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_results.Location = new System.Drawing.Point(6, 154);
            this.save_results.Name = "save_results";
            this.save_results.Size = new System.Drawing.Size(116, 27);
            this.save_results.TabIndex = 13;
            this.save_results.Text = "Save results";
            this.save_results.UseVisualStyleBackColor = false;
            this.save_results.Click += new System.EventHandler(this.save_results_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.operation2);
            this.groupBox2.Controls.Add(this.operation4);
            this.groupBox2.Controls.Add(this.operation1);
            this.groupBox2.Controls.Add(this.operation3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(384, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 204);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // operation2
            // 
            this.operation2.BackColor = System.Drawing.Color.IndianRed;
            this.operation2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.operation2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.operation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation2.Location = new System.Drawing.Point(6, 68);
            this.operation2.Name = "operation2";
            this.operation2.Size = new System.Drawing.Size(116, 27);
            this.operation2.TabIndex = 14;
            this.operation2.Text = "Operation №2";
            this.operation2.UseVisualStyleBackColor = false;
            this.operation2.Click += new System.EventHandler(this.operation2_Click);
            // 
            // operation4
            // 
            this.operation4.BackColor = System.Drawing.Color.IndianRed;
            this.operation4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.operation4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.operation4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation4.Location = new System.Drawing.Point(6, 154);
            this.operation4.Name = "operation4";
            this.operation4.Size = new System.Drawing.Size(116, 27);
            this.operation4.TabIndex = 13;
            this.operation4.Text = "Operation №4";
            this.operation4.UseVisualStyleBackColor = false;
            this.operation4.Click += new System.EventHandler(this.operation4_Click);
            // 
            // operation1
            // 
            this.operation1.BackColor = System.Drawing.Color.IndianRed;
            this.operation1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.operation1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.operation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation1.Location = new System.Drawing.Point(6, 25);
            this.operation1.Name = "operation1";
            this.operation1.Size = new System.Drawing.Size(116, 27);
            this.operation1.TabIndex = 2;
            this.operation1.Text = "Operation №1";
            this.operation1.UseVisualStyleBackColor = false;
            this.operation1.Click += new System.EventHandler(this.operation1_Click);
            // 
            // operation3
            // 
            this.operation3.BackColor = System.Drawing.Color.IndianRed;
            this.operation3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.operation3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.operation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation3.Location = new System.Drawing.Point(7, 111);
            this.operation3.Name = "operation3";
            this.operation3.Size = new System.Drawing.Size(116, 27);
            this.operation3.TabIndex = 3;
            this.operation3.Text = "Operation №3";
            this.operation3.UseVisualStyleBackColor = false;
            this.operation3.Click += new System.EventHandler(this.operation3_Click);
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_C.Location = new System.Drawing.Point(431, 12);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(24, 20);
            this.label_C.TabIndex = 14;
            this.label_C.Text = "C:";
            // 
            // numericUpDown_c
            // 
            this.numericUpDown_c.Location = new System.Drawing.Point(461, 12);
            this.numericUpDown_c.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown_c.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDown_c.Name = "numericUpDown_c";
            this.numericUpDown_c.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown_c.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(519, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(519, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Result:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(519, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Result:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(519, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Result:";
            // 
            // textBox_result1
            // 
            this.textBox_result1.Location = new System.Drawing.Point(574, 152);
            this.textBox_result1.Name = "textBox_result1";
            this.textBox_result1.ReadOnly = true;
            this.textBox_result1.Size = new System.Drawing.Size(86, 20);
            this.textBox_result1.TabIndex = 20;
            // 
            // textBox_result2
            // 
            this.textBox_result2.Location = new System.Drawing.Point(574, 192);
            this.textBox_result2.Name = "textBox_result2";
            this.textBox_result2.ReadOnly = true;
            this.textBox_result2.Size = new System.Drawing.Size(86, 20);
            this.textBox_result2.TabIndex = 21;
            // 
            // textBox_result3
            // 
            this.textBox_result3.Location = new System.Drawing.Point(574, 234);
            this.textBox_result3.Name = "textBox_result3";
            this.textBox_result3.ReadOnly = true;
            this.textBox_result3.Size = new System.Drawing.Size(86, 20);
            this.textBox_result3.TabIndex = 22;
            // 
            // textBox_result4
            // 
            this.textBox_result4.Location = new System.Drawing.Point(574, 278);
            this.textBox_result4.Name = "textBox_result4";
            this.textBox_result4.ReadOnly = true;
            this.textBox_result4.Size = new System.Drawing.Size(86, 20);
            this.textBox_result4.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(678, 362);
            this.Controls.Add(this.textBox_result4);
            this.Controls.Add(this.textBox_result3);
            this.Controls.Add(this.textBox_result2);
            this.Controls.Add(this.textBox_result1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_c);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_array);
            this.Controls.Add(this.textBox_array);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.numericUpDown_b);
            this.Controls.Add(this.numericUpDown_a);
            this.Controls.Add(this.numericUpDown_size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Work with arrays";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generate_array;
        private System.Windows.Forms.Button save_array;
        private System.Windows.Forms.NumericUpDown numericUpDown_size;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.NumericUpDown numericUpDown_b;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TextBox textBox_array;
        private System.Windows.Forms.Label label_array;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button read_array;
        private System.Windows.Forms.Button save_results;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button operation2;
        private System.Windows.Forms.Button operation4;
        private System.Windows.Forms.Button operation1;
        private System.Windows.Forms.Button operation3;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.NumericUpDown numericUpDown_c;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_result1;
        private System.Windows.Forms.TextBox textBox_result2;
        private System.Windows.Forms.TextBox textBox_result3;
        private System.Windows.Forms.TextBox textBox_result4;
    }
}

