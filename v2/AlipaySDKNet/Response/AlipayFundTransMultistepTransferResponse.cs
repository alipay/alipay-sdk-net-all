using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransMultistepTransferResponse.
    /// </summary>
    public class AlipayFundTransMultistepTransferResponse : AopResponse
    {
        /// <summary>
        /// 单据单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 单据转账状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
