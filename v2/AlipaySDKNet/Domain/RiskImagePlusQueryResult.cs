using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskImagePlusQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class RiskImagePlusQueryResult : AopObject
    {
        /// <summary>
        /// 风险分析-风险标签
        /// </summary>
        [XmlElement("info_code")]
        public string InfoCode { get; set; }

        /// <summary>
        /// 风险咨询结果描述
        /// </summary>
        [XmlElement("risk_desc")]
        public string RiskDesc { get; set; }

        /// <summary>
        /// 风险咨询类型
        /// </summary>
        [XmlElement("risk_type")]
        public string RiskType { get; set; }

        /// <summary>
        /// 风险咨询结果，匹配风险咨询类型，rank等级数字由小到大风险依次增大。最高风险等级为rank5
        /// </summary>
        [XmlElement("risk_value")]
        public string RiskValue { get; set; }
    }
}
