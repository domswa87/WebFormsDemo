using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<int> MyList { get; set; } = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            MyList.Add(10);
            MyList.Add(20);
            MyList.Add(30);

            GridViewDS.DataSource = MyList;
            GridViewDS.DataBind();
        }

        protected void GridViewDS_Init(object sender, EventArgs e)
        {
            int i = 1;
        }

        protected void ButtonClick(object sender, EventArgs e)
        {
            Debug.WriteLine("DS_From_Button");
        }
    }
}