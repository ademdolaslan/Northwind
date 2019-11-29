using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL.Entities
{
    public class LoginInfoEntity
    {
        private string _userUsername;
        private string _userPassword;
        private string _userId;

        public string userId { get => _userId; set => _userId = value; }
        public string userPassword { get => _userPassword; set => _userPassword = value; }
        public string userUsername { get => _userUsername; set => _userUsername = value; }

    }
}
