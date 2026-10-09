using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayInfoDTO : AopObject
    {
        /// <summary>
        /// 支付金额，单位元
        /// </summary>
        [XmlElement("act_pay_amount")]
        public string ActPayAmount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("act_pay_time")]
        public string ActPayTime { get; set; }

        /// <summary>
        /// 填写支付资金类型，例如租金 RENT，买断金 BUYOUT
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 租赁期数，fund_type=rent 必填
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 优惠金额，单位元
        /// </summary>
        [XmlElement("promo_amount")]
        public string PromoAmount { get; set; }

        /// <summary>
        /// 租赁阶段，fund_type=rent 必填
        /// </summary>
        [XmlElement("stage")]
        public string Stage { get; set; }
    }
}
