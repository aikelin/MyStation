using Bolg.App_Code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bolg.UserConrols
{
    public partial class ValidateString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CommonClass cc = new CommonClass();
            string randomString = cc.RandomNum(4);
            CreateImage(randomString);
        }

        private void CreateImage(string randomString)
        {
            Bitmap bitmap = new Bitmap(58,22);
            Graphics g = Graphics.FromImage(bitmap);
            Font font = new Font("arial", 12);
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0,0,bitmap.Width,bitmap.Height),Color.Blue,Color.Red,1.2f,true);
            g.DrawString(randomString, font, brush, 2, 0);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            Response.ClearContent();
            Response.ContentType = "image/gif";
            Response.BinaryWrite(ms.ToArray());
        }
    }
}