using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Repository
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
            this.sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["HMS"].ConnectionString);
            //this.Sqlcon = new SqlConnection(@"Data Source=HASIB-LAPTOP;Initial Catalog=sampledb;Persist Security Info=True;User ID=sa;Password=P@$$w0rd");
            Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public SqlDataReader ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            return sqlcom.ExecuteReader();

            /*this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;*/
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
