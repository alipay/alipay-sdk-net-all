using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerMarketingRefundResponse.
    /// </summary>
    public class AlipayVoyagerMarketingRefundResponse : AopResponse
    {
        /// <summary>
        /// 退款单号，三方用于对账
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 业务结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
