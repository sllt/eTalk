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

namespace IM
{
    public partial class FrmNotification : dyForm.CForm.NewSkinForm
    {
        bool isLoadOver = false;

        public FrmNotification()
        {
            InitializeComponent();
        }

        private void FrmNotification_Load(object sender, EventArgs e)
        {
            int H = DateTime.Now.Hour;
            this.BackgroundImage =
                H > 5 & H <= 11 ? Properties.Resources.morning :
                H > 11 & H <= 16 ? Properties.Resources.noon :
                H > 16 & H <= 19 ? Properties.Resources.afternoon :
                Properties.Resources.night;

            timer.Start();
            tmrLoad.Start();
            isLoadOver = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Rectangle rect = new Rectangle();
            rect = Screen.GetWorkingArea(this);

            int height = this.Top;
            while (this.Top < rect.Height)
            {
                this.SetBounds(rect.Width - this.Width - 20, height += 20, this.Width, this.Height);
                Application.DoEvents();
                Thread.Sleep(50);
            }
            this.Close();
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            if (isLoadOver == true)
            {
                isLoadOver = false;
                tmrLoad.Stop();
                Rectangle rect = new Rectangle();
                rect = Screen.GetWorkingArea(this);
                int height = rect.Height + 40;
                while (this.Top > rect.Height - this.Height)
                {
                    this.SetBounds(rect.Width - this.Width - 20, height -= 20, this.Width, this.Height);
                    Application.DoEvents();
                    Thread.Sleep(20);
                }
                this.SetBounds(rect.Width - this.Width - 20, rect.Height - this.Height, this.Width, this.Height);
            }
        }
    }
}
