using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageTopostpaidConsultResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageTopostpaidConsultResponse : AopResponse
    {
        /// <summary>
        /// 原始待退款金额（分）
        /// </summary>
        [XmlElement("origin_refund_amount")]
        public string OriginRefundAmount { get; set; }

        /// <summary>
        /// 待退款金额（分）
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
