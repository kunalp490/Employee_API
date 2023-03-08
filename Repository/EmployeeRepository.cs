using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee_API.Model;
using Employee_API.Repository.Interface;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace Employee_API.Repository
{
    public class EmployeeRepository : IEmployee
    {
        string connStr = "server=127.0.0.1;user=root;password=LTI@12345;database=employeedb;port=3306";
        public List<EmployeeList> getAll_Employees()
        {

            List<EmployeeList> emps = new List<EmployeeList>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getAll_Employees";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeList e1 = new EmployeeList();

                    e1.id = Convert.ToInt32(reader["id"].ToString());
                    e1.name = reader["name"].ToString();
                    e1.gender = reader["gender"].ToString();
                    e1.age = reader["age"].ToString();
                    e1.designation = reader["designation"].ToString();
                    e1.DateOfJoin = reader["DateOfJoin"].ToString();
                    e1.CTC = Convert.ToDouble(reader["CTC"].ToString());

                    emps.Add(e1);
                }
            }

                return emps;
        }

        public EmployeeList getEmployee_byID(int id)
        {
            EmployeeList e1 = new EmployeeList();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getEmployee_byID";
                cmd.Parameters.AddWithValue("_id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    e1.id = Convert.ToInt32(reader["id"].ToString());
                    e1.name = reader["name"].ToString();
                    e1.gender = reader["gender"].ToString();
                    e1.age = reader["age"].ToString();
                    e1.designation = reader["designation"].ToString();
                    e1.DateOfJoin = reader["DateOfJoin"].ToString();
                    e1.CTC = Convert.ToDouble(reader["CTC"].ToString());

                }
            }

            return e1;
        }

        public string remove_Employee_byID()
        {
            return "";
        }
    }
}
