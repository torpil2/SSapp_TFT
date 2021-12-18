using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

using Utilities;

namespace TftScreenShoot
{


    public partial class Form1 : Form
    {
        globalKeyboardHook gkh = new globalKeyboardHook();


       string dosyayolu,eskidosyayolu;
        int dosyasayisi ;
        
       
   
        public Form1()
        {
            //  this.TopMost = true;          
            InitializeComponent();
         //   this.KeyDown += new KeyEventHandler(Form1_KeyDown);



           //this.Load += new EventArgs(Form1_Load);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            
           
                           
           if(e.KeyCode ==Keys.E)
            {
                button1.PerformClick();
            }
            }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            try { 
          if(e.KeyCode == Keys.Space)
            {
                button1.PerformClick();
                e.Handled = true;
            }
            }
            catch(Exception)
            {

            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            gkh.HookedKeys.Add(Keys.Space);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Keydown(object sender, KeyEventArgs e)
        {
          
            
            
        }

        private void pictureBox1_Keydown(object sender,KeyEventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                /*    int screenLeft = SystemInformation.VirtualScreen.Left;
              int screenTop = SystemInformation.VirtualScreen.Top;
              int screenWidth = SystemInformation.VirtualScreen.Width;
              int screenHeight = SystemInformation.VirtualScreen.Height;
              eskidosyasayisi = dosyasayisi;


                  using (Bitmap bmp = new Bitmap(screenWidth, screenHeight))
                  {
                      using (Graphics g = Graphics.FromImage(bmp))
                      {
                          String filename = "RakipEkran-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".png";
                          Opacity = .0;
                          g.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
                          bmp.Save("Z:\\ScreenShoots\\" + filename);
                          Opacity = 1;

                          pictureBox1.Image = Image.FromFile("Z:\\ScreenShoots\\" + filename);
                      }
                  }*/


                //////////////////////
                this.Hide();
                System.Threading.Thread.Sleep(100);
                 SendKeys.Send("{PRTSC}");
                    Image myImage = Clipboard.GetImage();
                    dosyayolu = "C:\\tftss\\board"+ dosyasayisi +".jpg";
                    pictureBox1.Image = myImage;
                 eskidosyayolu = dosyayolu;
                    File.Delete(eskidosyayolu);
                 // dosyasayisi =  dosyasayisi + 1;
                    myImage.Save(dosyayolu);
                    this.Show();
                          
            
            }
            catch(Exception)
            {

            }
            
        }
    }
}
