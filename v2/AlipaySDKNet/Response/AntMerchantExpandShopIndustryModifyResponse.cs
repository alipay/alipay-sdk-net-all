using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandShopIndustryModifyResponse.
    /// </summary>
    public class AntMerchantExpandShopIndustryModifyResponse : AopResponse
    {
        /// <summary>
        /// 申请单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
