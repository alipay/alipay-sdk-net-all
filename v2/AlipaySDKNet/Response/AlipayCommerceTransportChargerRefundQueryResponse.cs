using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerRefundQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 退款金额。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 行业退款业务流水号
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 退款状态。REFUND_SUCCESS（退款成功）、REFUNDING（退款中）、REFUND_FAIL（退款失败）
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }
    }
}
