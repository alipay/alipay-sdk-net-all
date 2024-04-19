using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardRefundQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 可退金额，精确到分
        /// </summary>
        [XmlElement("refundable_amount")]
        public string RefundableAmount { get; set; }
    }
}
