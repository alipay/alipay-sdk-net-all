using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignRestrictInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SignRestrictInfo : AopObject
    {
        /// <summary>
        /// 产品码，支付宝定义的产品码
        /// </summary>
        [XmlElement("restrict_product")]
        public string RestrictProduct { get; set; }

        /// <summary>
        /// 受限的原因
        /// </summary>
        [XmlElement("restrict_reason")]
        public string RestrictReason { get; set; }

        /// <summary>
        /// 受限原因编码
        /// </summary>
        [XmlElement("restrict_reason_code")]
        public string RestrictReasonCode { get; set; }

        /// <summary>
        /// 受限版本，02-受限版 04-极速版
        /// </summary>
        [XmlElement("restrict_version")]
        public string RestrictVersion { get; set; }
    }
}
