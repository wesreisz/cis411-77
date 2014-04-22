using GeoCodeTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            String address = txtAddressInput.Text;
            GeoResult geoResult = GeoUtil.getResultFromAddress(address);

            lblAddressFullStuff.Text =
                String.Format("{0} whatever {1} , {2}", 
                    geoResult.results[0].formatted_address, 
                    geoResult.results[0].geometry.location.lat, 
                    geoResult.results[0].geometry.location.lng
                );
        }
    }
}