using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandBizaccessOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBizaccessOrderCancelModel : AopObject
    {
        /// <summary>
        /// 主单id 
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
