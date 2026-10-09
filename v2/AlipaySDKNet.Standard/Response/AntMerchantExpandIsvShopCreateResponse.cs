using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIsvShopCreateResponse.
    /// </summary>
    public class AntMerchantExpandIsvShopCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
