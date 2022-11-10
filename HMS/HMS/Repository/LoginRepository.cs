using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Repository
{
    class LoginRepository
    {
        DataAccess dataAccess;
        public LoginRepository()
        {
            dataAccess = new DataAccess();
        }

        public Login Validation(Login log)
        {
            string sql = "SELECT * FROM Login WHERE UserName='" + log.UserName + "' And Password='" + log.Passsword + "'";
            SqlDataReader reader = dataAccess.ExecuteQuery(sql);
            try
            {
                reader.Read();
                int userType = (int)reader["UserType"];
                log.UserType = userType;
                return log;


            }
            catch (Exception e)
            {
                log.UserType = 0;
                Console.WriteLine(e);
                return log;
            }

        }
    }
}
