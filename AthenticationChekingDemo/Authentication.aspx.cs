using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AthenticationChekingDemo
{
    public partial class Authentication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<b>User Name : </b>" + User.Identity.Name + "<br>");
            Response.Write("<b>Whats the Authentication Type : </b>" + User.Identity.AuthenticationType + "<br>");
            Response.Write("<b>Is he Authenticated : </b>" + User.Identity.IsAuthenticated + "<br>");
            Response.Write("<b>Is He Administrstor : </b>" + User.IsInRole("Administrators") + "<br>");
        }
    }
}