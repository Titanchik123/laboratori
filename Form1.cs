using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaia
{
    public partial class main : Form
{
        int curGroupNum, curSMNin, curEtapNum;
        public main()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
           

            string inName =vvodbox.Text.Trim();
            if (inName != "")
            {
                massuch.Rows.Add(inName);
                vvodbox.Clear();
                vvodbox.Focus();
                if (massuch.Rows.Count == Program.smcount) 
                {
                    vvodbox.Enabled = false;
                    addfio.Enabled = false;
                    groop.Visible = true; 
                    
                }
            }
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        

        

        private void vvodbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void groop_Click(object sender, EventArgs e)
        {
           

          // dataGridView1.Rows.Count == 5;
            for (int i = 0; i <4; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[i, 0].Value = massuch[0, i].Value;
                dataGridView1.Rows.Add();
                dataGridView1[i, 1].Value = massuch[0, i+4].Value;
                dataGridView1.Rows.Add();
                dataGridView1[i, 2].Value = massuch[0, i+8].Value;
                dataGridView1.Rows.Add();
                dataGridView1[i, 3].Value = massuch[0, i+12].Value;
            }
            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows.RemoveAt(4);
                dataGridView1.Refresh();
            }




            Program.grop1 = new участник[4];
            Program.grop2 = new участник[4];
            Program.grop3 = new участник[4];
            Program.grop4 = new участник[4];
            for (int i = 0; i < Program.grop1.Length; i++)
            {
             Program.grop1[i] = new участник();
             Program.grop1[i].results=new int[Program.ecount1];
             Program.grop1[i].Name = dataGridView1[0,i].Value.ToString();
            }
            for (int i = 0; i < Program.grop2.Length; i++)
            {
             Program.grop2[i] = new участник();
             Program.grop2[i].results = new int[Program.ecount1];
             Program.grop2[i].Name = dataGridView1[1, i].Value.ToString();
            }
            for (int i = 0; i < Program.grop3.Length; i++)
            {
             Program.grop3[i] = new участник();
             Program.grop3[i].results = new int[Program.ecount1];
             Program.grop3[i].Name = dataGridView1[2, i ].Value.ToString();
            }
            for (int i = 0; i < Program.grop4.Length; i++)
            {
             Program.grop4[i] = new участник();
             Program.grop4[i].results = new int[Program.ecount1];
             Program.grop4[i].Name = dataGridView1[3, i ].Value.ToString();

            }

            groop.Enabled = false;
            tabControl1.SelectedIndex++;
            curGroupNum = curSMNin = curEtapNum = 0;
            label3.Text = Program.grop1[curSMNin].Name;
            label6.Text = curEtapNum.ToString() + "раунд";

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (curGroupNum == 0)
            {
                Program.grop1[curGroupNum].results[curEtapNum] = (int)numericUpDown1.Value;
            }
            else { Program.grop2[curGroupNum].results[curEtapNum] = (int)numericUpDown1.Value; }
            curEtapNum++;
            if (curEtapNum == Program.ecount1) ;         // {
               // curEtapNum 0;
               // curSMNin++;
               // int cmpSMval;
              //  if (curGroupNum 0)
                //        cmpSMval  
                    

                    
           // }
        
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
