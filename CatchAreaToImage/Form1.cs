using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CatchAreaToImage.Form1;

namespace CatchAreaToImage
{

    public partial class Form1 : Form
    {
        private Screenshot objScreenshot;

        public Form1()

        {   InitializeComponent();
            objScreenshot = new Screenshot();
        }
        private void TakeSnap()
        {
            var snap = objScreenshot.GetSnapShot();
            AddToPreview(snap);
        }
        private void AddToPreview(Bitmap snap)
        {
            pBArea.Image = snap ;
            string filePath = Path.Combine(
             Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            snap.Save(@""+filePath + "\\png.png", ImageFormat.Png);
            
        }
        private void BtnSelectArea_Click_1(object sender, EventArgs e)
        {

            Form2 f = new Form2();
                f.Show();


            objScreenshot.SetCanvas();


                TakeSnap();

                f.Close();




        }
    }
}

