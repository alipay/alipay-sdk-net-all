using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskItemVO : AopObject
    {
        /// <summary>
        /// 命中的风险详细信息 当前字段已废弃(字段删除，后续不再透出)
        /// </summary>
        [XmlElement("hit_detail")]
        public string HitDetail { get; set; }

        /// <summary>
        /// 风险编码
        /// </summary>
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 【订单维度共租风险】nor-无共租行为, low-低风险, mid-中风险, high-高风险, sup-超高风险；
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }
    }
}
