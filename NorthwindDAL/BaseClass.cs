using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using NorthwindDAL.Entities;

namespace NorthwindDAL
{
    public class BaseClass
    {
        public string _connectionString = "DATA SOURCE=ADEMDOLASLAN:1521/XE;PERSIST SECURITY INFO=True;USER ID=NORTHWIND;PASSWORD=123123";
        OracleConnection _connection = new OracleConnection();
        OracleDataReader dr;
        OracleDataAdapter da = new OracleDataAdapter();
        OracleCommand cmd = new OracleCommand();
        DataTable dt;
        public string sql;
        public List<Entities.OrderBetweendateEntity> siparisliste = new List<Entities.OrderBetweendateEntity>();
        public Object userInfoObject;
        public DataTable getOrderList(string date1, string date2)
        {
            try
            {
                _connection.ConnectionString = _connectionString;
                _connection.Open();
                
                cmd = _connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandText = "NORTHWIND.PAKET.FNC_ORDERS_BETWEEN_DATE";
                cmd.CommandText = "NORTHWIND.PAKET.FNC_ORDERS_BETWEEN_DATE";
                cmd.Parameters.Add("rcSonuc", OracleDbType.RefCursor, System.Data.ParameterDirection.ReturnValue);
                cmd.Parameters.Add("p_date1", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = date1;
                cmd.Parameters.Add("p_date2", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = date2;
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = _connection;
                dt = new DataTable("rcSonuc");
                da.Fill(dt);
                _connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                var a = ex.Message.ToString();
                return dt;
            }

        }
        public int denemeeeeeeee(string kadi,string sfr)
        {
            try
            {
                _connection.ConnectionString = _connectionString;
                _connection.Open();

                cmd = _connection.CreateCommand(); 
                cmd.CommandType = System.Data.CommandType.StoredProcedure;               
                cmd.CommandText = "NORTHWIND.DEN";
                cmd.Parameters.Add("result", OracleDbType.Int64, System.Data.ParameterDirection.ReturnValue);
                cmd.Parameters.Add("p_kadi", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = kadi;
                cmd.Parameters.Add("p_sfr", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = sfr;
                cmd.ExecuteNonQuery();
                var a = int.Parse(cmd.Parameters["result"].Value.ToString());
                return a;
            }
            catch (Exception ex)
            {
                return 10000;
            }

           
        }
        public string kriptola(string userName, string password)
        {
            char[] chrAry = userName.ToCharArray();
            string p1 = chrAry[1].ToString() + chrAry[3].ToString() + chrAry[5].ToString() + chrAry[7].ToString()
                + chrAry[9].ToString();
            string p2 = chrAry[0].ToString() + chrAry[2].ToString() + chrAry[4].ToString() + chrAry[6].ToString()
                + chrAry[8].ToString();
            password += (Convert.ToInt32(p1) + Convert.ToInt32(p2)).ToString();
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(password));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public string InsertLoginInfo(string userid, string username, string userpassword)
        {
            try
            {
                _connection.ConnectionString = _connectionString;
                _connection.Open();
                cmd = _connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "NORTHWIND.PAKET.PROC_INSERT_LOGIN_VALUES";
                cmd.Parameters.Add("P_ID", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = userid;
                cmd.Parameters.Add("P_USERNAME", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = username;
                cmd.Parameters.Add("P_PASSWORD", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = userpassword;
                cmd.ExecuteNonQuery();
                _connection.Close();
                return "Ekleme Başarılı!!";

            }
            catch (Exception ex)
            {
                string a = ex.Message.ToString();
                return a;
            }


        }
        public DataTable getUserloginInfo(string userName, string userPassword)
        {
            try
            {
                _connection.ConnectionString = _connectionString;
                _connection.Open();
                cmd = _connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "NORTHWIND.PAKET.FNC_LOGIN_RETURN_USER";
                cmd.Parameters.Add("rcSonuc", OracleDbType.RefCursor, System.Data.ParameterDirection.ReturnValue);
                cmd.Parameters.Add("P_USERNAME", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = userName;
                cmd.Parameters.Add("P_PASSWORD", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = kriptola(userName, userPassword);
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = _connection;
                dt = new DataTable("rcSonuc");
                da.Fill(dt);
                _connection.Close();                
                return dt;
            }
            catch (Exception ex)
            {
                var a = ex.Message.ToString();
                return dt;
            }
        }
        public string insertOrder(AddOrderEntity order)
        {         
            try
            {
                _connection.ConnectionString = _connectionString;
                _connection.Open();
                cmd = _connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "NORTHWIND.PAKET.PROC_ADD_ORDER";
                cmd.Parameters.Add("P_CUSTOMERID", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = order.customerId;
                cmd.Parameters.Add("P_EMPLOYEEID", OracleDbType.Int64, System.Data.ParameterDirection.Input).Value = order.employeeId;
                cmd.Parameters.Add("P_ORDERDATE", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = order.orderDate.Date.ToShortDateString();
                cmd.Parameters.Add("P_REQUIREDDATE", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = order.requiredDate.Date.ToShortDateString();
                cmd.Parameters.Add("P_SHIPPEDDATE", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = order.shippedDate.Date.ToShortDateString();
                cmd.Parameters.Add("P_SHIPVIA", OracleDbType.Int64, System.Data.ParameterDirection.Input).Value = order.shipVia;
                cmd.Parameters.Add("P_FREIGHT", OracleDbType.Int64, System.Data.ParameterDirection.Input).Value = order.freight;
                cmd.Parameters.Add("P_SHIPNAME", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = order.shipName;
                cmd.Parameters.Add("P_SHIPADDRESS", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = order.shipAddress;
                cmd.Parameters.Add("P_SHIPCITY", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = order.shipCity;
                cmd.Parameters.Add("P_SHIPREGION", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = order.shipRegion;
                cmd.Parameters.Add("P_SHIPPOSTALCODE", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = order.shipPostalcode;
                cmd.Parameters.Add("P_SHIPCOUNTRY", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = order.shipCountry;
                cmd.Parameters.Add("OUT_SEQ_VALUE", OracleDbType.Int64, System.Data.ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                _connection.Close();
                return cmd.Parameters["OUT_SEQ_VALUE"].Value.ToString() ;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string insertOrderDetails(AddOrderDetailEntity detail)
        {
            try
            {
                _connection.ConnectionString = _connectionString;
                _connection.Open();
                cmd = _connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "NORTHWIND.PAKET.PROC_ADD_ORDER_DETAIL";
                cmd.Parameters.Add("P_ORDERDETAIL_ORDERID", OracleDbType.Int64, System.Data.ParameterDirection.Input).Value = detail.orderId;
                cmd.Parameters.Add("P_ORDERDETAIL_PRODUCTID", OracleDbType.Int64, System.Data.ParameterDirection.Input).Value = detail.productId;
                cmd.Parameters.Add("P_ORDERDETAIL_UNITPRICE", OracleDbType.Int64, System.Data.ParameterDirection.Input).Value = detail.unitPrice;
                cmd.Parameters.Add("P_ORDERDETAIL_QUANTITY", OracleDbType.Int64, System.Data.ParameterDirection.Input).Value = detail.quantity;
                cmd.Parameters.Add("P_ORDERDETAIL_DISCOUNT", OracleDbType.Int64, System.Data.ParameterDirection.Input).Value = detail.discount;
                cmd.ExecuteNonQuery();
                _connection.Close();
                return "Ekleme Başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

            
        }
    }
}
