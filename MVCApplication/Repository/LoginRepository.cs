using MVCApplication.CommonClass;
using MVCApplication.Models.Account;
using Newtonsoft.Json;
using System;
using System.Data;

namespace MVCApplication.Repository
{
    public class LoginRepository
    {
        #region Variable Declarations
        private ConnectionHelper objCons;
        #endregion

        #region Private Methods
        private void assignConnection()
        {
            objCons = new ConnectionHelper();
        }
        #endregion

        public string ValidateLoginCredentials(string userName, string password)
        {
            assignConnection();
            try
            {
                string query = "select * from dbo.registration where user_name = '" + userName + "'"
                                    + " and password= '" + password + "'";
                DataTable dtResult = new DataTable();
                dtResult = objCons.GetData(query);

                if (dtResult.Rows.Count > 0)
                {
                    return "success";
                }
                return "fail";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string RegisterUser(string strReq)
        {
            assignConnection();
            try
            {
                Registration req = new Registration();
                req = JsonConvert.DeserializeObject<Registration>(strReq);
                int result = objCons.InsertData(string.Format("INSERT INTO  registration (first_name,last_name,email,mobile_number,password,retype_password,user_name" +
                             ") values ('{0}','{1}','{2}',{3},'{4}','{5}','{6}')", req.first_name, req.last_name, req.email, req.mobile_number, req.password, req.retype_password, req.user_name));
                if (result > 0)
                {
                    return "success";
                }
                return "false";
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //public string RegisterUser(string firstName, string lastName,string email, int mobileNumber,string password, string retypePassword,string userName)
        //{
        //    assignConnection();
        //    try
        //    {

        //      int result =   objCons.InsertData(string.Format("INSERT INTO  registration (first_name,last_name,email,mobile_number,password,retype_password,user_name" +
        //                   ") values ('{0}','{1}','{2}',{3},'{4}','{5}','{6}')",  firstName, lastName, email, mobileNumber, password, retypePassword, userName));
        //        if (result > 0)
        //        {
        //            return "success";
        //        }
        //        return "false";
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
    }
}