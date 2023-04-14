using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftSimplecreateResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftSimplecreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
