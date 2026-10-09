using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitRewardConfig Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitRewardConfig : AopObject
    {
        /// <summary>
        /// 权益展示信息
        /// </summary>
        [XmlElement("display_info")]
        public BenefitDisplayInfoResponse DisplayInfo { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 来源编号
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
