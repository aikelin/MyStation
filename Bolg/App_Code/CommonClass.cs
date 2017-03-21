using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Bolg.App_Code
{
    public class CommonClass
    {

        public string MessageBox(string TxtMessage)
        {
            string str;
            str = "<script language=javascript>alert('" + TxtMessage + "')</script>";
            return str;
        }

        public string MessageBox(string TxtMessage, string Url)
        {
            string str;
            str = "<script language=javascript>alert('" + TxtMessage + "');location='" + Url + "';</script>";
            return str;
        }

        public string MessageBoxPage(string TxtMessage)
        {
            string str;
            str = "<script language=javascript>alert('" + TxtMessage + "');location='javascript:history.go(-1)';</script>";
            return str;
        }

        public string RandomNum(int n)
        {
            string strChar = "0,1,2,3,4,5,6,7,8,9";
            
            string[] VcArray = strChar.Split(',');
            int strCharLength = VcArray.Length;
            string randString="";
            Random rand = new Random();
            int lastRand = -1;
            for(int i=0;i< n; i++)
            {
                int randNum;
                randNum = rand.Next(strCharLength-1);
                if(lastRand != -1)
                {
                    rand = new Random(i * randNum * unchecked((int)DateTime.Now.Ticks));
                }
                if(lastRand != -1 && lastRand == randNum)
                {
                    return RandomNum(n);
                }
                lastRand = randNum;
                randString += VcArray[randNum];                            
            }
            return randString;
        }

        public bool Check(Page page)
        {
            string usertype = page.Session["usertype"] == null ? null : page.Session["usertype"].ToString();
            if(usertype == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}