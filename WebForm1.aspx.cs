using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace challenge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string num = "0123456789";
            int len = num.Length;
            string otp = string.Empty;
            int otpdigit = 5;
            string finaldigit;
            int getindex;
            for (int i = 0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getindex].ToString();

                } while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit;
            }
            11.Text = otp;
        }
    }
}