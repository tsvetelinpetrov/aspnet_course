using RegisterAndLogin.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegisterAndLogin.Services
{
    public class SecurityService
    {

        UsersDAO usersDAO;

        public SecurityService()
        {
            usersDAO =  new UsersDAO();
        }

        // Return true if the user is found in the list
        public bool isValid(UserModel user)
        {
            return usersDAO.findUserByNameAndPassword(user);
        }
    }
}
