using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoBenefitCheckavailableModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoBenefitCheckavailableModel : AopObject
    {
        /// <summary>
        /// 支付宝权益编码标识
        /// </summary>
        [XmlElement("benefit_code")]
        public string BenefitCode { get; set; }

        /// <summary>
        /// 预留扩展字段
        /// </summary>
        [XmlElement("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 支付宝用户标识
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
