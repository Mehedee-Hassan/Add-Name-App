using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_name
{
    public partial class AddNameFrom : Form
    {
        public AddNameFrom()
        {
            InitializeComponent();
        }
        int totalCount = 0;
        string[] name = new string[10];



        private void button2_Click(object sender, EventArgs e)
        {


            if (totalCount >= 10)
            {
                MessageBox.Show(@"No Empty Place Found ,Reset Please");
            }
            else 
            if (nameTextBox.Text != "")
            {
                showNameListBox.Items.Add(nameTextBox.Text);
                
                name[totalCount] = nameTextBox.Text;


                nameTextBox.Text = "";
                totalCount++;
                addCountCounterLabel.Text = totalCount.ToString();
            }
        }


  
        private void button1_Click(object sender, EventArgs e)
        {

            showNameListBox.Items.Clear();

            if (name.Length != 0)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if(name[i] != null)
                    showNameListBox.Items.Add(name[i]);
                }

                //foreach (string nameAdd in name)
                //{
                //    showNameListBox.Items.Add(nameAdd);
                //}
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showNameListBox.Items.Clear();
            addCountCounterLabel.Text = "0";
            totalCount = 0;
            name = new string[10];
        }
    }
}
