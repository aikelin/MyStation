using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bolg.management
{
    public partial class ValidateNum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string randomNum = CreateRandomNum(4);
            Session["ValidateNum"] = randomNum;
            CreateImage(randomNum);
        }

        private string CreateRandomNum(int numCount)
        {
            string allstr = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,W,X,Y,Z";
            string[] allchar = allstr.Split(',');
            string randomNum = "";
            Random ran = new Random();
            for (int i = 0; i < numCount; i++)
            {
                int tmp = ran.Next(35);
                randomNum += allchar[tmp];
            }
            return randomNum;
        }

        private void CreateImage(string randonNum)
        {
            Bitmap bitmap = new Bitmap(58, 22);
            Graphics g = Graphics.FromImage(bitmap);
            Font font = new Font("arial", 12);
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, bitmap.Width, bitmap.Height), Color.Blue, Color.Red, 1.2f, true);
            g.DrawString(randonNum, font, brush, 2, 0);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            Response.ClearContent();
            Response.ContentType = "image/gif";
            Response.BinaryWrite(ms.ToArray());
        }
    }
}