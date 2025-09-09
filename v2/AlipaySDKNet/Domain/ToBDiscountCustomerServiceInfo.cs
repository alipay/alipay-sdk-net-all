using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ToBDiscountCustomerServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ToBDiscountCustomerServiceInfo : AopObject
    {
        /// <summary>
        /// 当前订单对应的客服链接
        /// </summary>
        [XmlElement("customer_service_link")]
        public string CustomerServiceLink { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [XmlElement("customer_service_mobile")]
        public string CustomerServiceMobile { get; set; }
    }
}
