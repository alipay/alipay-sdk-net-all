using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceRiskCheckResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceRiskCheckResponse : AopResponse
    {
        /// <summary>
        /// 风控是否准入
        /// </summary>
        [XmlElement("access")]
        public bool Access { get; set; }

        /// <summary>
        /// 风控拒绝原因
        /// </summary>
        [XmlElement("reject_reason_code")]
        public string RejectReasonCode { get; set; }

        /// <summary>
        /// 拒绝原因详情
        /// </summary>
        [XmlElement("reject_reason_detail")]
        public string RejectReasonDetail { get; set; }
    }
}
