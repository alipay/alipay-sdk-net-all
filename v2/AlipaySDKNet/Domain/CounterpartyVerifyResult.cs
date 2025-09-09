using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CounterpartyVerifyResult Data Structure.
    /// </summary>
    [Serializable]
    public class CounterpartyVerifyResult : AopObject
    {
        /// <summary>
        /// 存在转账关系的企业列表
        /// </summary>
        [XmlArray("ent_list")]
        [XmlArrayItem("counterparty_info")]
        public List<CounterpartyInfo> EntList { get; set; }

        /// <summary>
        /// 近6个月是否与风险池存在转账关系
        /// </summary>
        [XmlElement("is_match_risk_list")]
        public string IsMatchRiskList { get; set; }
    }
}
