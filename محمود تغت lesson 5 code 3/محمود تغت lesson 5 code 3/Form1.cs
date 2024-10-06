using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace محمود_تغت_lesson_5_code_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread Threadgo;
        private void button1_Click(object sender, EventArgs e)
        {
            Threadgo = new Thread(go);
            Threadgo.Start();
                   
        }
        void go()
        {
            while(but_sid.Left<(this.Width-but_sid.Width))
            {  
                Invoke((Action)(() =>//للوصول الى الاحداث من داخل الثرد
                  {
                      but_sid.Left += 5;
                  }));
                
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
          }

            }
        

        private void button2_Click(object sender, EventArgs e)
        {
          //  for (int i = 0; i < this.Height - but_dow.Height; i++) ;
            while(but_dow.Top<=(this.Height-but_dow.Height-50))
            {
                but_dow.Top+=5;
                System.Threading.Thread.Sleep(50);
                Application.DoEvents();

            }

        }

        private void but_sid_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Threadgo != null)
                Threadgo.Abort();
        }
    }
}
