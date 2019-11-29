using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL.Entities
{
   public  class UserınfoEntity
    {
        private string _customerId;
        private string _companyName;
        private string _contactName;
        private string _contactTitle;
        private string _address;
        private string _city;
        private string _region;
        private string _postalCode;
        private string _phone;
        private string _fax;
        private string _country;

        public string customerId { get => _customerId; set => _customerId = value; }
        public string companyName { get => _companyName; set => _companyName = value; }
        public string contactName { get => _contactName; set => _contactName = value; }
        public string contactTitle { get => _contactTitle; set => _contactTitle = value; }
        public string address { get => _address; set => _address = value; }
        public string city { get => _city; set => _city = value; }
        public string region { get => _region; set => _region = value; }
        public string postalCode { get => _postalCode; set => _postalCode = value; }
        public string country { get => _country; set => _country = value; }
        public string phone { get => _phone; set => _phone = value; }
        public string fax { get => _fax; set => _fax = value; }
    }
}
