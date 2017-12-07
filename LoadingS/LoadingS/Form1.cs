using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadingS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread thread = new Thread(new ThreadStart(Splash));
            thread.Start();
            InitializeComponent();
            //Loading data
            string str = string.Empty;
            for (int i = 0; i < 100000; i++)
            {
                str += i.ToString(); // Init data
            }
            //Complete
            thread.Abort();
        }

        void Splash()
        {
            SplashScreen.SplashForm splashForm = new SplashScreen.SplashForm();
            splashForm.AppName = "Test";
            Application.Run(splashForm);
        }
    }
}
