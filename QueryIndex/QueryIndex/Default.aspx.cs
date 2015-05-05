using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QueryIndex
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //var strQuery = "Select DocTitle,Filename,Size,PATH,URL from Scope() where FREETEXT(Contents,'" + this.txtContent.Text + "')";
            var strQuery = "Select DocTitle,Filename,Size,PATH,URL from Scope() where Filename='" + this.txtContent.Text + "'";
            string connstring = string.Format("Provider=\"MSIDXS\";Data Source=\"{0}\"", this.txtStorage.Text);

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection(connstring);
            conn.Open();

            System.Data.OleDb.OleDbDataAdapter cmd = new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);

            DataTable dt = new DataTable();

            cmd.Fill(dt);
            conn.Close();

            this.txtContent.Text = dt.Rows.Count.ToString();
            DataView source = new DataView(dt);
            grid.DataSource = source;
            grid.DataBind();


        }
    }
}