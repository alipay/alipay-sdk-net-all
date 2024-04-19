using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRiskResult Data Structure.
    /// </summary>
    [Serializable]
    public class RentRiskResult : AopObject
    {
        /// <summary>
        /// 风险咨询事件ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 风险等级中文描述
        /// </summary>
        [XmlElement("risk_desc")]
        public string RiskDesc { get; set; }

        /// <summary>
        /// 风险名称
        /// </summary>
        [XmlElement("risk_name")]
        public string RiskName { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [XmlElement("risk_rank")]
        public string RiskRank { get; set; }

        /// <summary>
        /// 子风险项
        /// </summary>
        [XmlElement("sub_rent_risk_result")]
        public SubRentRiskResult SubRentRiskResult { get; set; }
    }
}
