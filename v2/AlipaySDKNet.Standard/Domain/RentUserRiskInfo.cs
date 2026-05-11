using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentUserRiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentUserRiskInfo : AopObject
    {
        /// <summary>
        /// risk_level字段取值范围T1-T10（T1 ~ T4: 低风险；T5 ~ T6: 中风险；T7 ~ T8: 高风险；T9 ~ T10: 极高风险）
        /// </summary>
        [XmlElement("comprehensive_risk_level")]
        public string ComprehensiveRiskLevel { get; set; }

        /// <summary>
        /// 优质用户推荐标识
        /// </summary>
        [XmlElement("premium_user_recommend")]
        public bool PremiumUserRecommend { get; set; }
    }
}
