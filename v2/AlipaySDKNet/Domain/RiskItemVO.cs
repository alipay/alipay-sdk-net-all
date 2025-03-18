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
        /// 命中的风险详细信息
        /// </summary>
        [XmlElement("hit_detail")]
        public string HitDetail { get; set; }

        /// <summary>
        /// 风险编码
        /// </summary>
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 【订单维度共租风险】low / mid / high； 【小程序维度共租风险:】P1 ~ P6，数字越大风险越高； 【高风险黑名单】true-命中黑名单 false-未命中； 【低风险推荐发货】true-推荐发货 false-非推荐发货用户，需要商家综合其他信息自主决策；
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }
    }
}
