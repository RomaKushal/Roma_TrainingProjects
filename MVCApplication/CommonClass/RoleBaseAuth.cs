using System;
using System.Data;
using System.Linq;
using System.Web.Security;

namespace MVCApplication.CommonClass
{
    public class RoleBaseAuth : RoleProvider
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
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        private String[] roleList;
        public override string[] GetRolesForUser(string username)
        {
            assignConnection();

            try
            {
                string query = "select distinct role from dbo.registration where role != null ";
                DataTable dtResult = new DataTable();
                dtResult = objCons.GetData(query);
                roleList = dtResult.Rows[0].ItemArray.Select(a => a.ToString()).ToArray();

                return roleList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}