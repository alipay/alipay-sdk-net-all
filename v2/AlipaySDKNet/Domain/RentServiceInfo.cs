using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentServiceInfo : AopObject
    {
        /// <summary>
        /// 资方信息
        /// </summary>
        [XmlElement("capital_principal")]
        public ParticipantInfoDTO CapitalPrincipal { get; set; }

        /// <summary>
        /// 邀请方
        /// </summary>
        [XmlElement("invite_principal")]
        public ParticipantInfoDTO InvitePrincipal { get; set; }

        /// <summary>
        /// 租金，单位：元
        /// </summary>
        [XmlElement("repayment_amount")]
        public string RepaymentAmount { get; set; }

        /// <summary>
        /// 还款截止时间
        /// </summary>
        [XmlElement("repayment_end_time")]
        public string RepaymentEndTime { get; set; }

        /// <summary>
        /// 扣款周期次数（期）
        /// </summary>
        [XmlElement("repayment_period")]
        public string RepaymentPeriod { get; set; }

        /// <summary>
        /// 扣款周期类型
        /// </summary>
        [XmlElement("repayment_period_type")]
        public string RepaymentPeriodType { get; set; }
    }
}
