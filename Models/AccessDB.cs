using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class AccessDB
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-VJM76VP\\PAVISQL;Initial Catalog=UserProfile;Integrated Security=True;Pooling=False");
        public string AddEmployeeRecord(ModelFile employeeEntities)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_Name", employeeEntities.departmentList);
                cmd.Parameters.AddWithValue("@City", employeeEntities.year);
                cmd.Parameters.AddWithValue("@State", employeeEntities.Amount);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Data save Successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
    }
}