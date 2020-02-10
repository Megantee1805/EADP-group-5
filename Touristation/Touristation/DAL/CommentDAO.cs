using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using Touristation.BLL;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Touristation.DAL
{
    public class CommentDAO
    {
        public List<comment> SelectAll()
        {
            string connectionstring = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);

            string sqlm = "select * from comment";
            SqlDataAdapter da = new SqlDataAdapter(sqlm, conn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            List<comment> comm = new List<comment>();
            int rec = ds.Tables[0].Rows.Count;
            for (int i=0; i<rec; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string Id = row["Id"].ToString();
                string Loca = row["Loca"].ToString();
                int Rate = Convert.ToInt16(row["Rate"].ToString());
                string Com = row["Com"].ToString();
                int userid = Convert.ToInt16(row["userid"].ToString());
                comment obj = new comment(Id, Loca, Rate, Com, userid);
                comm.Add(obj);
            }

            return comm;
        }

        public comment SelectById(string Id)
        {
            string connectionstring = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);

            string sqlm = "select * from comment where id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlm, conn);

            da.SelectCommand.Parameters.AddWithValue("@paraIs", Id);

            DataSet ds = new DataSet();

            da.Fill(ds);

            comment cmnt = null;
            int rec = ds.Tables[0].Rows.Count;
            if (rec == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string Loca = row["Loca"].ToString();
                int Rate = Convert.ToInt16(row["Rate"].ToString());
                string Com = row["Com"].ToString();
                int userid = Convert.ToInt16(row["userid"].ToString());
                cmnt = new comment(Id, Loca, Rate, Com, userid);
            }
            else
            {
                cmnt = null;
            }

            return cmnt;

        }

        public int Insert(comment cmnt)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand();

            string connectionstring = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);

            string sqlm = "INSERT INTO comment(Id, Loca, Rate, Com, userid)" + 
                "VALUES (@paraId, @paraLoca, @paraRate, @paraCom, @userid)";
            cmd = new SqlCommand(sqlm, conn);
            cmd.Parameters.AddWithValue("@paraId", cmnt.Id);
            cmd.Parameters.AddWithValue("@paraLoca", cmnt.Loca);
            cmd.Parameters.AddWithValue("@paraRate", cmnt.Rate);
            cmd.Parameters.AddWithValue("@paraCom", cmnt.Com);
            cmd.Parameters.AddWithValue("@parauserid", cmnt.userid);

            conn.Open();
            result = cmd.ExecuteNonQuery();

            conn.Close();

            return result;
        }
    }
}