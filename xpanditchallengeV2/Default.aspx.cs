using SharedModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xpanditchallengeV2
{
    public partial class Default : Page
    {
        public string ConnName
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["xpanditchallengeDB"].ConnectionString;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvDataBindPersons(false);
            }
        }

        protected void gvContacts_Sorting(object sender, GridViewSortEventArgs e)
        {

        }

        protected void gvContacts_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        #region private methods
        private void gvDataBindPersons(bool filter)
        {
            DataTable dt = Person.getListPersonsDT(ConnName);

            gvContacts.DataSource = dt;
            gvContacts.DataBind();

        }
        #endregion
    }
}