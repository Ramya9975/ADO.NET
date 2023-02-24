using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    internal class Program
    {
        //string sqlselect;

        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=NLTI159\\SQLEXPRESS;database= Practises;" + "integrated security = true;");
            //string sqlSelect = "SELECT id, name FROM ramya";


            //SqlCommand cmd = new SqlCommand("select * from ramya");

            SqlDataAdapter dr = new SqlDataAdapter("select * from ramya",con);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            DataView dataView= new DataView(dt);
            //for(int i=0;i<dataView.Count;i++) 
            //{
            //    Console.WriteLine(dataView[i]["id"].ToString() + dataView[i]["Name"].ToString() + dataView[i]["Subject"].ToString());
            //}
            //foreach(DataRowView dataRowView in dataView)
            //{
            //    DataRow row = dataRowView.Row;
            //    Console.WriteLine(dataRowView["id"].ToString() + "," + dataRowView["Name"].ToString() + "," + dataRowView["Subject"].ToString());
            //}
            //dataView.AllowNew = true;
            //DataRowView dataRowView1 = dataView.AddNew();
            //dataRowView1["id"] = 6;
            //dataRowView1["Name"] = "yuva";
            //dataRowView1["Subject"] = "Physics";


            dataView.RowFilter = "Name='Rekha'";

            foreach (DataRowView dataRowView in dataView)
            {
                DataRow row = dataRowView.Row;
                Console.WriteLine(dataRowView["id"].ToString() + "," + dataRowView["Name"].ToString() + "," + dataRowView["Subject"].ToString());
            }

            
            dataView.AllowEdit = true;
            foreach(DataRowView dataRowView in dataView) 
            {
                if (Convert.ToString(dataRowView["id"])=="1")
                {
                    dataRowView["Subject"] = "biology";
                }
            }
            foreach (DataRowView dataRowView in dataView)
            {
                DataRow row = dataRowView.Row;
                Console.WriteLine(dataRowView["id"].ToString() + "," + dataRowView["Name"].ToString() + "," + dataRowView["Subject"].ToString());
            }


            //foreach (DataRow da in dt.Rows)
            //{
            //    Console.WriteLine(da[0].ToString() + "," + da[1].ToString());
            //}
            //Console.WriteLine("---------------------------------------------");
            //DataSet data = new DataSet();
            //dr.Fill(data,"ramya");
            //foreach (DataRow dataRow in data.Tables["ramya"].Rows)
            //{
            //    Console.WriteLine(dataRow[0].ToString()+"," + dataRow[1].ToString());
            //}






            //cmd.Connection= con;
            //con.Open();


            //SqlDataReader dr = cmd.ExecuteReader();
            //while(dr.Read()) 
            // {
            // Console.WriteLine(dr["id"].ToString() + ",");
            //Console.WriteLine(dr["Name"].ToString() + ",");
            //Console.WriteLine(dr["Subject"].ToString() + ",");
            //}
            //dr.Close();
            //con.Close();
            Console.Read();

        }
    }
}
