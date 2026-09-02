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
        /// 0、1、2、3、4、5，从0到5履约能力变高，风险变低
        /// </summary>
        [XmlElement("credit_ability_level")]
        public string CreditAbilityLevel { get; set; }

        /// <summary>
        /// nor-无在租订单, low-低风险, mid-中风险, high-高风险
        /// </summary>
        [XmlElement("current_renting_level")]
        public string CurrentRentingLevel { get; set; }

        /// <summary>
        /// low-低风险, mid-中风险, high-高风险，sup-极高风险
        /// </summary>
        [XmlElement("intermediary_level")]
        public string IntermediaryLevel { get; set; }

        /// <summary>
        /// 优质用户推荐标识
        /// </summary>
        [XmlElement("premium_user_recommend")]
        public bool PremiumUserRecommend { get; set; }
    }
}
