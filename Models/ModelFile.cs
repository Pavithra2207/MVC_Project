using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Models
{
    public class ModelFile
    {
        public ModelFile()
        {
            departmentList = new List<SelectListItem>();
            year = new List<SelectListItem>();
        }
        [DisplayName("Category")]
        [Required]
        public List<SelectListItem> departmentList
        {
            get;
            set;
        }
        [DisplayName("Year")]
        [Required]
        public List<SelectListItem> year
        {
            get;
            set;
        }

        [Required]
        public int Amount { get; set; }

        public void InsertRegDetails(ModelFile obj)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VJM76VP\\PAVISQL;Initial Catalog=UserProfile;Integrated Security=True" );
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Insert into Details values('" + obj.departmentList + "','" + obj.year + "'," + obj.Amount + "')";
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Success");
            }
            catch (Exception e)
            {

            }
        }
    }
}