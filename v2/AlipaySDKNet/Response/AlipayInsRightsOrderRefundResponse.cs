using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsRightsOrderRefundResponse.
    /// </summary>
    public class AlipayInsRightsOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 返回当前退单的结果
        /// </summary>
        [XmlElement("refund_valid")]
        public bool RefundValid { get; set; }
    }
}
