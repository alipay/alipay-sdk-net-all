using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftforcCreateResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftforcCreateResponse : AopResponse
    {
        /// <summary>
        /// 跳转地址
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
