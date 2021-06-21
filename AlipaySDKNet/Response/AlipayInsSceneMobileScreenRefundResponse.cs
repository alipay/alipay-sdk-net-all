using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneMobileScreenRefundResponse.
    /// </summary>
    public class AlipayInsSceneMobileScreenRefundResponse : AopResponse
    {
        /// <summary>
        /// 退保保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 退保保费
        /// </summary>
        [XmlElement("surrender_premium")]
        public string SurrenderPremium { get; set; }
    }
}
