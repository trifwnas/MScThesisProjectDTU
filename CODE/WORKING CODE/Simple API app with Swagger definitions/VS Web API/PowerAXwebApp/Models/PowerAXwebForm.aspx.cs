using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZXing;

namespace PowerAXwebApp.Models
{
    public partial class PowerAXwebForm : System.Web.UI.Page
    {
        public int myflag = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            // create a barcode reader instance
            IBarcodeReader reader = new BarcodeReader();
            // load a bitmap
            var barcodeBitmap = (Bitmap)Bitmap.FromFile("C:\\Users\\Trif\\Google Drive\\DTU\\Thesis\\downloaded\barCodeDensity.jpg"); //   .LoadFrom("C:\\sample-barcode-image.png");
            // detect and decode the barcode inside the bitmap
            var result = reader.Decode(barcodeBitmap);
            // do something with the result
            if (result != null)
            {
                myflag = 1;
                //txtDecoderType.Text = result.BarcodeFormat.ToString();
                //txtDecoderContent.Text = result.Text;
            }
            //////// ZXing.mobile
            //buttonScan.Click += (sender, e) => {

//#if __ANDROID__
//    // Initialize the scanner first so it can track the current context
//    MobileBarcodeScanner.Initialize (Application);
//#endif

//                var scanner = new ZXing.Mobile.MobileBarcodeScanner();

//                var result = await scanner.Scan();

//                if (result != null)
//                    Console.WriteLine("Scanned Barcode: " + result.Text);
//            };

        }
    }
}