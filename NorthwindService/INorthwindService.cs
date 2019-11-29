using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NorthwindDAL.Entities;

namespace NorthwindService
{
    
    [ServiceContract]
    public interface INorthwindService
    {
        #region XML INTERFACES
        [OperationContract]
        List<NorthwindDAL.Entities.OrderBetweendateEntity> getOrderInfo(string d1, string d2);





        [OperationContract]
        List<NorthwindDAL.Entities.UserınfoEntity> getLoginInfo(string p_username, string p_password);

        [OperationContract]
        int ss(string k, string s);

        [OperationContract]
        string insertUserLoginInfo(string uid, string uname, string upw);

        [OperationContract]
        string addOrder(AddOrderEntity data);

        [OperationContract]
        string addOrderDetail(AddOrderDetailEntity detail_data);

        [OperationContract]
        string asd();

        [OperationContract]
        UserınfoEntity ue(UserınfoEntity entity);

        #endregion 

        #region JSON INTERFACES

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/JsongetOrderInfo/{d1},{d2}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<NorthwindDAL.Entities.OrderBetweendateEntity> JsongetOrderInfo(string d1, string d2);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/JsongetLoginInfo/{p_username},{p_password}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<NorthwindDAL.Entities.UserınfoEntity> JsongetLoginInfo(string p_username, string p_password);



        [OperationContract]
        string JsoninsertUserLoginInfo(string uid, string uname, string upw);

        [OperationContract]
        string JsonaddOrder(AddOrderEntity data);

        [OperationContract]
        string JsonaddOrderDetail(AddOrderDetailEntity detail_data);

        [OperationContract]
        string Jsonasd();

        #endregion

    }

    [DataContract]
    public class ordersDetails
    {
        private string _productSales;
        private string _productName;
        private string _categoryName;

        [DataMember]
        public string categoryName
        {
            get => _categoryName;
            set => _categoryName = value;
        }
        [DataMember]
        public string productName
        {
            get => _productName;
            set => _productName = value;
        }
        [DataMember]
        public string productSales
        {
            get => _productSales;
            set => _productSales = value;
        }
    }
}
