using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandZftChargerelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandZftChargerelationQueryModel : AopObject
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
