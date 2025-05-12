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
        /// 【订单维度共租风险】low / mid / high； 【小程序交易健康度】数值范围 0.0 ~ 5.0 ，值越大越健康；
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }
    }
}
