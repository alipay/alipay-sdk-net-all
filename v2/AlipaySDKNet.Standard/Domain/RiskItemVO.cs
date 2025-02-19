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
        /// 风险编码
        /// </summary>
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 【订单维度共租风险】low / mid / high； 【小程序维度共租风险】P1 ~ P6；
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }
    }
}
