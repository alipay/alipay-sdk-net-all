using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubsidyAmountParam Data Structure.
    /// </summary>
    [Serializable]
    public class SubsidyAmountParam : AopObject
    {
        /// <summary>
        /// 补充计算金额，必须大于0
        /// </summary>
        [XmlElement("subsidy_amount")]
        public string SubsidyAmount { get; set; }

        /// <summary>
        /// 补充金额计算模式
        /// </summary>
        [XmlElement("subsidy_mode")]
        public string SubsidyMode { get; set; }

        /// <summary>
        /// 补充金额类型
        /// </summary>
        [XmlElement("subsidy_type")]
        public string SubsidyType { get; set; }
    }
}
