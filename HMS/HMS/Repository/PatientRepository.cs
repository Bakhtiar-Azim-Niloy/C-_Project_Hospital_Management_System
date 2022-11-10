using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Entities;
using System.Data.SqlClient;

namespace HMS.Repository
{
    class PatientRepository
    {
        DataAccess db = new DataAccess();
        SqlDataReader reader;

        public List<Patient> GetAll()
        {
            string sql = "Select * From Patient";
            reader = db.ExecuteQuery(sql);
            List<Patient> allPatient = new List<Patient>();
            while (reader.Read())
            {
                Patient patient = new Patient();
                patient.Name = reader["Name"].ToString();
                patient.Gender = reader["Gender"].ToString();
                patient.Phone = reader["Phone"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.ChckInDate = reader["CheckInDate"].ToString();
                patient.Age = Convert.ToInt32(reader["Age"]);
                patient.PatientType = reader["PatientType"].ToString();
                patient.RoomType = reader["RoomType"].ToString();
                patient.RoomNo = reader["RoomNumber"].ToString();
                patient.Consultant = reader["Consultant"].ToString();
                patient.charge = reader["Charge"].ToString();
                patient.Sypmtoms = reader["Sypmtoms"].ToString();
                patient.Diagnosis = reader["Diagnosis"].ToString();
                patient.Prescription = reader["Prescription"].ToString();
                patient.ReadyToRelease = reader["ReadyToRealease"].ToString();
                patient.Status = reader["Status"].ToString();
                patient.CheckOutDate = reader["CheckOutDate"].ToString();


                allPatient.Add(patient);
            }
            return allPatient;
        }
        public Patient Get(Patient patients)
        {
            try
            {
                string sql = " Select * From Patient Where Phone='" + patients.Phone + "'";
                reader = db.ExecuteQuery(sql);
                while (reader.Read())
                {
                    patients.Name = reader["Name"].ToString();
                    patients.Gender = reader["Gender"].ToString();
                    patients.Phone = reader["Phone"].ToString();
                    patients.Address = reader["Address"].ToString();
                    patients.ChckInDate = reader["CheckInDate"].ToString();
                    patients.Age = Convert.ToInt32(reader["Age"]);
                    patients.PatientType = reader["PatientType"].ToString();
                    patients.RoomType = reader["RoomType"].ToString();
                    patients.RoomNo = reader["RoomNumber"].ToString();
                    patients.Consultant = reader["Consultant"].ToString();
                    patients.charge = reader["Charge"].ToString();
                    patients.Sypmtoms = reader["Sypmtoms"].ToString();
                    patients.Diagnosis = reader["Diagnosis"].ToString();
                    patients.Prescription = reader["Prescription"].ToString();
                    patients.ReadyToRelease = reader["ReadyToRealease"].ToString();
                    patients.Status = reader["Status"].ToString();
                    patients.CheckOutDate = reader["CheckOutDate"].ToString();
                }
                return patients;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Insert(Patient patient)
        {
           
            string sql = "Insert Into Patient Values('" + patient.Name + "','" + patient.Gender + "','" + patient.Phone + "','" + patient.Address + "','" + patient.ChckInDate + "','" + patient.Age + "','" + patient.PatientType + "','" + patient.RoomType + "','" + patient.RoomNo + "','" + patient.Consultant + "','" + patient.charge + "','" + patient.Sypmtoms + "','" + patient.Diagnosis + "','" + patient.ReadyToRelease + "','" + patient.Prescription + "','" + patient.Status + "','" + patient.CheckOutDate + "')";
            

            int result = db.ExecuteUpdateQuery(sql);
           // db.Sqlcon.Close();
            //db.Sqlcon.Open();
            
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }

        public bool Update(Patient patient)
        {
            try
            {

                string sql = " Update Patient Set Name='" + patient.Name + "',Gender='" + patient.Gender + "',Address='" + patient.Address + "',Age='" + patient.Age + "',CheckInDate='" + patient.ChckInDate + "',PatientType='" + patient.PatientType + "',RoomType='" + patient.RoomType + "',RoomNumber='" + patient.RoomNo + "',Consultant='" + patient.Consultant + "', Charge='" + patient.charge  + "'Where Phone='" + patient.Phone + "' ";

                int result = db.ExecuteUpdateQuery(sql);
                if (result > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
      
        public bool UpdateForDoc(Patient patient)
        {
            try
            {

                string sql = " Update Patient Set Name='" + patient.Name + "',Age='" + patient.Age + "',Diagnosis='" + patient.Diagnosis + "',Sypmtoms='" + patient.Sypmtoms +  "',ReadyToRealease='" + patient.ReadyToRelease  + "'Where Phone='" + patient.Phone + "' ";

                int result = db.ExecuteUpdateQuery(sql);
                if (result > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool UpdatePrescription(Patient patient)
        {
            try
            {
                string sql = " Update Patient Set Name='" + patient.Name + "',Prescription='" + patient.Prescription  + "'Where Phone='" + patient.Phone + "' ";
                int result = db.ExecuteUpdateQuery(sql);
                if (result > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateCheckOut(Patient patient)
        {
            try
            {
                string sql = " Update Patient Set Name='" + patient.Name + "',Status='" + patient.Status+ "',CheckOutDate='" + patient.CheckOutDate + "'Where Phone='" + patient.Phone + "' ";
                int result = db.ExecuteUpdateQuery(sql);
                if (result > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(Patient patient)
        {
            try
            {
                string sql = "Delete From Patient Where Phone='" + patient.Phone + "'";
                int result = db.ExecuteUpdateQuery(sql);
                if (result > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
