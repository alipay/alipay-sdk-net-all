using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParkingMembershipInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ParkingMembershipInfo : AopObject
    {
        /// <summary>
        /// 周卡、月卡：剩余天数（包括今天），单位日； 次卡：剩余次数（包括本次），单位次； 储值：余额，单位元； 折扣：折扣力度，代表0-10折；0折即为免费；
        /// </summary>
        [XmlElement("membership_balance")]
        public string MembershipBalance { get; set; }

        /// <summary>
        /// 会员类型； WEEK_CARD：周卡 MONTH_CARD：月卡 SEASON_CARD：季卡 YEAR_CARD：年卡 MULTIPLE_PASS_CARD：次卡 MONEY_STORED_CARD：储值 DISCOUNT_CARD：折扣
        /// </summary>
        [XmlElement("membership_type")]
        public string MembershipType { get; set; }
    }
}
