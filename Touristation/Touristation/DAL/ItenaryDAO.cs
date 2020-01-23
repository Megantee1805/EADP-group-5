﻿using Itenary.BLL;
using System;
using System.Collections.Generic;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Touristation.BLL;

namespace Itenary.DAL
{
    public class ItenaryDAO
    {
        public List<ItenaryX> SelectAll()
        {

            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);


            string sqlStmt = "Select * from Itenary";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);


            DataSet ds = new DataSet();


            da.Fill(ds);


            List<ItenaryX> itnList = new List<ItenaryX>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                DateTime doe = Convert.ToDateTime(row["Date"].ToString());
                string time = row["Time"].ToString();
                string name = row["NamePlace"].ToString();
                string location = row["Location"].ToString();
                ItenaryX obj = new ItenaryX(doe, time, name, location);
                itnList.Add(obj);
            }

            return itnList;
        }
        public int Insert(ItenaryX itn)
        {

            int result = 0;
            SqlCommand sqlCmd = new SqlCommand();


            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);


            string sqlStmt = "INSERT INTO Itenary ( Date, Time, NamePlace, Location) " +
                "VALUES (@paradate, @paratime, @paraplace, @paralocation)";
            sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd.Parameters.AddWithValue("@paradate", itn.EventDate);
            sqlCmd.Parameters.AddWithValue("@paratime", itn.Time);
            sqlCmd.Parameters.AddWithValue("@paraplace", itn.Name);
            sqlCmd.Parameters.AddWithValue("@paralocation", itn.Location);

            try
            {
                myConn.Open();

                sqlCmd.ExecuteNonQuery();
                result = 1;

            }

            catch (Exception e)
            {
                result = 0;
            }
            myConn.Close();

            return result;
        }
        public ItenaryX SelectById(string id)
        {

            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);


            string sqlStmt = "Select * from Itenary where id = @paraid";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraid", id);


            DataSet ds = new DataSet();


            da.Fill(ds);


            ItenaryX itn = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string time = row["time"].ToString();
                DateTime doe = Convert.ToDateTime(row["Date"].ToString());
                string name = row["NamePlace"].ToString();
                string location = row["Location"].ToString();

                itn = new ItenaryX(doe, time, name, location);
            }
            else
            {
                itn = null;
            }

            return itn;
        }
        public int Update(ItenaryX itn)
        {
            int result = 0;
            using (TouristationEntityModel sqlC = new TouristationEntityModel())
            {
            }

                string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Instantiate SqlCommand instance to add record 
            //          with INSERT statement
            string sqlStmt = "UPDATE Itenary SET name = @paradate = Date, @paratime = Time, @paraplace = NamePlace, @paralocation = Location " +
                " where id = @paraid ";

            sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paradate", itn.EventDate);
            sqlCmd.Parameters.AddWithValue("@paraplace", itn.Name);
            sqlCmd.Parameters.AddWithValue("@paratime", itn.Time);
            sqlCmd.Parameters.AddWithValue("@paralocation", itn.Location);

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        }
    }
}