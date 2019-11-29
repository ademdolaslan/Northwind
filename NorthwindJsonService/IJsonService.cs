using NorthwindDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NorthwindDAL;



namespace NorthwindJsonService
{
    
    [ServiceContract]
    public interface IJsonService
    {
        [OperationContract]
        List<NorthwindDAL.Entities.OrderBetweendateEntity> getOrderInfo(string d1, string d2);

        [OperationContract]
        List<NorthwindDAL.Entities.UserınfoEntity> getLoginInfo(string p_username, string p_password);

        [OperationContract]
        string insertUserLoginInfo(string uid, string uname, string upw);

        [OperationContract]
        string addOrder(AddOrderEntity data);

        [OperationContract]
        string addOrderDetail(AddOrderDetailEntity detail_data);

        [OperationContract]
        string asd();

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
