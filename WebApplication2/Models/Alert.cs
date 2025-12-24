using System;
using System.Web.UI;

namespace WebApplication2.Models
{
    public class Alert
    {
        public static void Show(Page page, Type type, string message)
        {
            ScriptManager.RegisterStartupScript(page, type, "alert", $"alert('{message}');", true);
        }
    }
}