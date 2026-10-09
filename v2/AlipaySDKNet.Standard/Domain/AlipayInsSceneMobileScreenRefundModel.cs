using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneMobileScreenRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneMobileScreenRefundModel : AopObject
    {
        /// <summary>
        /// 请求渠道来源
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 退保保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
