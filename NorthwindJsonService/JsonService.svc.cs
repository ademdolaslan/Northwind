using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindDAL;
using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NorthwindDAL.Entities;

namespace NorthwindJsonService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IJsonService
    {
        public List<NorthwindDAL.Entities.OrderBetweendateEntity> getOrderInfo(string d1, string d2)
        {
            List<NorthwindDAL.Entities.OrderBetweendateEntity> liste = new List<NorthwindDAL.Entities.OrderBetweendateEntity>();
            BaseClass bc = new BaseClass();
            DataTable tablo = bc.getOrderList(d1, d2);
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                NorthwindDAL.Entities.OrderBetweendateEntity order = new NorthwindDAL.Entities.OrderBetweendateEntity();
                order.categoryName = tablo.Rows[i]["CATEGORYNAME"].ToString();
                order.productName = tablo.Rows[i]["PRODUCTNAME"].ToString();
                order.productSales = tablo.Rows[i]["PRODUCTSALES"].ToString();
                liste.Add(order);
            }
            return liste;
        }
        public string insertUserLoginInfo(string uid, string uname, string upw)
        {
            BaseClass bc = new BaseClass();
            return bc.InsertLoginInfo(uid, uname, bc.kriptola(uname, upw));
        }
        public List<NorthwindDAL.Entities.UserınfoEntity> getLoginInfo(string p_username, string p_password)
        {
            try
            {
                List<NorthwindDAL.Entities.UserınfoEntity> liste = new List<NorthwindDAL.Entities.UserınfoEntity>();
                BaseClass bc = new BaseClass();
                DataTable dt = bc.getUserloginInfo(p_username, p_password);
                if (dt.Rows.Count != 0)
                {
                    NorthwindDAL.Entities.UserınfoEntity person = new NorthwindDAL.Entities.UserınfoEntity();
                    person.customerId = dt.Rows[0]["CUSTOMERID"].ToString();
                    person.companyName = dt.Rows[0]["COMPANYNAME"].ToString();
                    person.contactName = dt.Rows[0]["CONTACTNAME"].ToString();
                    person.contactTitle = dt.Rows[0]["CONTACTTITLE"].ToString();
                    person.address = dt.Rows[0]["ADDRESS"].ToString();
                    person.city = dt.Rows[0]["CITY"].ToString();
                    person.region = dt.Rows[0]["REGION"].ToString();
                    person.postalCode = dt.Rows[0]["POSTALCODE"].ToString();
                    person.country = dt.Rows[0]["COUNTRY"].ToString();
                    person.phone = dt.Rows[0]["PHONE"].ToString();
                    person.fax = dt.Rows[0]["FAX"].ToString();
                    liste.Add(person);
                }
                return liste;
            }
            catch (NullReferenceException)
            {
                List<NorthwindDAL.Entities.UserınfoEntity> liste = new List<NorthwindDAL.Entities.UserınfoEntity>();
                return liste;
            }
        }
        public string addOrder(AddOrderEntity data)
        {
            BaseClass bc = new BaseClass();
            return bc.insertOrder(data);
        }

        public string addOrderDetail(AddOrderDetailEntity detail_data)
        {
            BaseClass bc = new BaseClass();
            return bc.insertOrderDetails(detail_data);
        }

        public string asd()
        {
            return DateTime.Now.Date.ToString();
        }
    }
}
