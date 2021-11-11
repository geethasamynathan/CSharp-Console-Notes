using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Async_Await_Demos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Countchars()
        {
            int count = 0;
            using (StreamReader reader=new StreamReader("D:\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        private   void btnProcessFile_Click(object sender, EventArgs e)
        {
            int count = 0;
         
          
            Thread thread = new Thread(() => 
            {
                count = Countchars();
                Action action = () => lblCountChar.Text = count.ToString() + "  Chars in File";
                // lblCountChar.Text = count.ToString() + "  Characters in File";
                this.BeginInvoke(action);
        
            });
            thread.Start();
            //thread.Join();
            lblCountChar.Text = "Processing  File Please Wait...";
           // lblCountChar.Text = count.ToString() + "  Characters in File";




            //Task<int> task = new Task<int>(Countchars);
            // task.Start();
            //int count = await task;
        }
    }
}
