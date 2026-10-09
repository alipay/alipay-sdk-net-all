using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentGovernanceInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentGovernanceInfoVO : AopObject
    {
        /// <summary>
        /// 治理处置方式
        /// </summary>
        [XmlElement("punishment")]
        public string Punishment { get; set; }

        /// <summary>
        /// 建议措施
        /// </summary>
        [XmlElement("suggestion")]
        public string Suggestion { get; set; }

        /// <summary>
        /// 结合治理维度，共同标识出治理的目标对象
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// bySubMerchantUSCC 表示二级商户统社码维度
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 违规内容描述
        /// </summary>
        [XmlElement("violation_desc")]
        public string ViolationDesc { get; set; }
    }
}
