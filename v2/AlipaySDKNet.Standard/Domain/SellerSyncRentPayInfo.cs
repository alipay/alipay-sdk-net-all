using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SellerSyncRentPayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SellerSyncRentPayInfo : AopObject
    {
        /// <summary>
        /// 实际支付金额，单位元
        /// </summary>
        [XmlElement("act_pay_amount")]
        public string ActPayAmount { get; set; }

        /// <summary>
        /// 实际支付时间
        /// </summary>
        [XmlElement("act_pay_time")]
        public string ActPayTime { get; set; }

        /// <summary>
        /// 资金类型 租金：RENT、买断金：BUYOUT
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 交易组件分期单号
        /// </summary>
        [XmlElement("installment_no")]
        public string InstallmentNo { get; set; }

        /// <summary>
        /// 优惠金额，单位元
        /// </summary>
        [XmlElement("promo_amount")]
        public string PromoAmount { get; set; }
    }
}
