using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;
using Woorj.Data.Core;

namespace Woorj.CtrApi.Core
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentApController
    {
        private readonly IConfiguration _configuration;

        public DepartmentApController(IConfiguration configuration)
        {
             _configuration= configuration;
        }

         [HttpGet("GetJson")]
        public JsonResult GetJson()
        {
            string query=@"
                        select Id,Name from dbo.Department";
        
          DataTable table= new DataTable();
          string sqlDataSource=_configuration.GetConnectionString("DefaultConnection");
          //Console.WriteLine("SQLConn="+sqlDataSource);
          SqlDataReader myReader;
            using(SqlConnection myCon=new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);

        }

          [HttpPost("CreateDepartment")]
        public JsonResult Post(Department dep)
        {
            string query = @"
                    insert into dbo.Department values 
                    ('"+dep.Name+@"')
                    ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }

        //[HttpPut("UpdateIndividual/{id}")]
        [HttpPut("UpdateDepartment")]        
        public JsonResult Put(Department dep)
        {
            string query = @"
                    update dbo.Department set 
                    Name = '"+dep.Name+@"'
                    where Id = "+dep.Id + @" 
                    ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }


        [HttpDelete("DeleteDepartnent/{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                    delete from dbo.Department
                    where Id = " + id + @" 
                    ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }


    }
}