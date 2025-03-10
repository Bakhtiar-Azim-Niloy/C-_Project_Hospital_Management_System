﻿using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Repository
{
    class WardRepository
    {
        DataAccess db = new DataAccess();
        SqlDataReader reader;

        public List<Ward> GetAll()
        {
            string sql = "Select * From Wards";
            reader = db.ExecuteQuery(sql);
            List<Ward> allWards = new List<Ward>();
            while (reader.Read())
            {
                Ward entity = new Ward();
                entity.Id = Convert.ToInt32(reader["Id"]);
                entity.Name = reader["Name"].ToString();
                entity.BedCount= Convert.ToInt32(reader["BedCount"]);
                entity.Price= Convert.ToDouble(reader["Price"]);

                allWards.Add(entity);
            }
            return allWards;
        }
        public Ward Get(Ward entity)
        {
            try
            {
                string sql = " Select * From Wards Where Id='" + entity.Id + "'";
                reader = db.ExecuteQuery(sql);
                while (reader.Read())
                {
                    entity.Id = Convert.ToInt32(reader["Id"]);
                    entity.Name = reader["Name"].ToString();
                    entity.BedCount = Convert.ToInt32(reader["BedCount"]);
                    entity.Price = Convert.ToDouble(reader["Price"]);

                }
                return entity;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Insert(Ward entity)
        {
            try
            {
                string sql = "Insert Into Wards (Name,BedCount,Price) Values('" + entity.Name + "', '"+entity.BedCount+"', '"+entity.Price+"')";

                db = new DataAccess();
                int result = db.ExecuteUpdateQuery(sql);

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
    }
}
