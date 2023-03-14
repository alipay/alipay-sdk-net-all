using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantBizParam Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantBizParam : AopObject
    {
        /// <summary>
        /// 出资比例
        /// </summary>
        [XmlElement("fund_ratio")]
        public string FundRatio { get; set; }

        /// <summary>
        /// 出资类型
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }
    }
}
