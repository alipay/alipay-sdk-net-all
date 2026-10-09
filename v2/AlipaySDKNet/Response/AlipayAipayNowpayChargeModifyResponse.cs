using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpayChargeModifyResponse.
    /// </summary>
    public class AlipayAipayNowpayChargeModifyResponse : AopResponse
    {
        /// <summary>
        /// 最新状态ENABLED/DISABLED
        /// </summary>
        [XmlElement("capability_status")]
        public string CapabilityStatus { get; set; }

        /// <summary>
        /// 是否实际发生状态变化
        /// </summary>
        [XmlElement("changed")]
        public bool Changed { get; set; }

        /// <summary>
        /// 展示说明
        /// </summary>
        [XmlElement("reason_message")]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// 最新状态版本
        /// </summary>
        [XmlElement("status_version")]
        public long StatusVersion { get; set; }
    }
}
