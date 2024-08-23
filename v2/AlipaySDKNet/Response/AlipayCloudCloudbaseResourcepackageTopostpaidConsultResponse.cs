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
        /// 待退款金额（分）
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
