using DoanWebNhomPV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DoanWebNhomPV
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod(EnableSession = true)]
        public string CheckLogin()
        {
            string Name = "";
            try
            {
                if (Session["LoginID" + Session.SessionID] == null)
                    return "";
                else
                    Name = Session["LoginName" + Session.SessionID].ToString();
            }
            catch { return ""; }
            return Name;
        }
        [WebMethod(EnableSession = true)]
        public bool Logout()
        {
            Session.Clear();
            var ID = Session["LoginID" + Session.SessionID];
            if (ID == null)
                return true;
            return false;
        }
        [WebMethod(EnableSession = true)]
        public int Buy(int masp, int sl)
        {
            var ID = Session["LoginID" + Session.SessionID];
            if (ID == null)
                return 2;
            if (!GIOHANGDAO.AddItem(Convert.ToInt32(ID), masp))
                return 1;
            return 0;
        }

    }
}
