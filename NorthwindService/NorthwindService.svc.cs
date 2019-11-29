using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NorthwindDAL;
using NorthwindDAL.Entities;

namespace NorthwindService
{
    public class NorthwindService : INorthwindService
    {
        #region  NORTHWIND SERVICE XML PARTS
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
        public UserınfoEntity ue(UserınfoEntity entity)
        {
            return entity;
        }

        public int ss(string k,string s)
        {
            BaseClass bc = new BaseClass();
            return bc.denemeeeeeeee(k, s);

        }

        #endregion
        #region NORTHWIND SERVICE JSON PARTS
        public List<NorthwindDAL.Entities.OrderBetweendateEntity> JsongetOrderInfo(string d1, string d2)
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
        public string JsoninsertUserLoginInfo(string uid, string uname, string upw)
        {
            BaseClass bc = new BaseClass();
            return bc.InsertLoginInfo(uid, uname, bc.kriptola(uname, upw));
        }
        public List<NorthwindDAL.Entities.UserınfoEntity> JsongetLoginInfo(string p_username, string p_password)
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
        public string JsonaddOrder(AddOrderEntity data)
        {
            BaseClass bc = new BaseClass();
            return bc.insertOrder(data);
        }

        public string JsonaddOrderDetail(AddOrderDetailEntity detail_data)
        {
            BaseClass bc = new BaseClass();
            return bc.insertOrderDetails(detail_data);
        }

        public string Jsonasd()
        {
            return DateTime.Now.Date.ToString();
        }

        #endregion
    }
}
