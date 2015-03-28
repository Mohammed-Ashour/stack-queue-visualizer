using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;


namespace stack
{
    public partial class Form1 : Form
    {
        //strings of all data to show
        string stack_s;
        string queue_s;
        //array of all data to process
        object[] array_stack;
        object[] array_queue;
        //our datastructures
        Stack my_stack;
        Queue my_queue;

        public Form1()

        {
            string stack_s;

            InitializeComponent();
            my_stack = new Stack();
            my_queue = new Queue();
            array_queue = my_queue.ToArray();
            array_stack = my_stack.ToArray();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   // pushing an element to our stack and update the textbox
            my_stack.Push(textBox1.Text);
            array_stack = my_stack.ToArray();
        
            stack_s = stack_s +Environment.NewLine + textBox1.Text;
            //option to clear the elements textbox
            //textBox1.Text = "";
            textBox4.Text = array_stack.First() + Environment.NewLine + textBox4 .Text ; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
          MessageBox.Show(my_stack.Peek().ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //check for the elements in the stack

            if (array_stack.Length == 0)
            {
                MessageBox.Show(" no element to pop ");
            }
            else

            {
                // get the peak and get rid of it 

                string pop_val = my_stack.Pop().ToString();
                stack_s = my_stack.ToString();
                textBox4.Text = "";
                for (int i = 0; i < array_stack.Length; i++)
                {
                    if (array_stack[i].ToString() == pop_val)
                    {
                        string rm = array_stack[i].ToString();
                        array_stack = array_stack.Where(val => val != rm).ToArray();
                    }


                }
                //rebuild our textbox after modification

                for (int i = array_stack.Length - 1; i >= 0; i--)
                {
                    textBox4.Text = array_stack[i] + Environment.NewLine + textBox4.Text;

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //push element to the queue
            my_queue.Enqueue(textBox1.Text);
            array_queue = my_queue.ToArray();
            queue_s += Environment.NewLine + textBox1.Text;
            //textBox3.Text =queue_s;
            //option to clear the elements textbox
            //textBox1.Text = "";
            textBox3.Text += array_queue.Last() + Environment.NewLine ; 


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //check for the elements in the queue
            if (array_queue.Length == 0)
            {
                MessageBox.Show(" no element to pop ");
            }
            else
            {
                // get the peak and get rid of it 
                string pop_val = my_queue.Dequeue().ToString();
                queue_s = my_queue.ToString();
                textBox3.Text = "";
                for (int i = 0; i < array_queue.Length; i++)
                {
                    if (array_queue[i].ToString() == pop_val)
                    {
                        string rm = array_queue[i].ToString();
                        array_queue = array_queue.Where(val => val != rm).ToArray();
                    }


                }
                //rebuild our textbox after modification
                for (int i = array_queue.Length - 1; i >= 0; i--)
                {
                    textBox3.Text = array_queue[i] + Environment.NewLine + textBox3.Text;

                }
            }


        }
    }
}
