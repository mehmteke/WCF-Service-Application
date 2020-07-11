using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfServiceSonuclar;

namespace WebApplicationForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Service1 service1 = new Service1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlOgrenciler.DataSource = service1.GetOgrencilers();
                ddlTurler.DataSource = service1.GetTurlers();
                ddlYillar.DataSource = service1.GetYillars();
            } 
        }
    }
}