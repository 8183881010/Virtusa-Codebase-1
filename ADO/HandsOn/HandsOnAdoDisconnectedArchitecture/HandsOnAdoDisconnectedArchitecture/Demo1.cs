using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace HandsOnAdoDisconnectedArchitecture
{
    //Disconnected Architecture
    class Demo1
    {
        //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["SqlConnection"]);
        SqlConnection con = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=VirtusaDB;Integrated Security=True");
      
        SqlDataAdapter da = null;
        DataSet ds = null;
        public void GetEmployees()
        {
            string qry = "Select Eid,Ename,Salary,JoinDate from Employee";
            da = new SqlDataAdapter(qry, con);
            //store the result set data into dataset
            ds = new DataSet();
            //fill the dataset
            da.Fill(ds, "Employee");
           
            foreach(DataRow row in ds.Tables["Employee"].Rows)
            {
                Console.WriteLine("ID:{0} Name:{1} Salary:{2} JoinDate:{3}", row["Eid"], row["Ename"], 
                    row["Salary"], row["JoinDate"]);
            }
           
          

        }
        static void Main()
        {
            Demo1 obj = new Demo1();
            obj.GetEmployees();
        }
    }
}
