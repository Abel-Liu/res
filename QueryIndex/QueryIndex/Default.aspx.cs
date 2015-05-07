using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace QueryIndex
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Search.CollatorDSO;Extended Properties=\"Application=Windows\"";
            OleDbConnection connection = new OleDbConnection(connectionString);

            string query = @"SELECT System.ItemName FROM SystemIndex WHERE FREETEXT('" + this.txtContent.Text + "')";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            connection.Open();

            var result = string.Empty;

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result += " - " + reader.GetString(0);
            }

            connection.Close();

            this.lab.Text = result;
        }
    }
}