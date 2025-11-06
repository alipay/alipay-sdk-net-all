using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAstoreOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAstoreOrderQueryModel : AopObject
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
