using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemRiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemRiskInfo : AopObject
    {
        /// <summary>
        /// 该商品最近一次审核完结时间
        /// </summary>
        [XmlElement("audit_time")]
        public string AuditTime { get; set; }

        /// <summary>
        /// 具体问题描述
        /// </summary>
        [XmlElement("risk_infos")]
        public Reasons RiskInfos { get; set; }
    }
}
