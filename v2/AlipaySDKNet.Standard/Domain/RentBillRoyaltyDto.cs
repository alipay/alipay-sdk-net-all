using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentBillRoyaltyDto Data Structure.
    /// </summary>
    [Serializable]
    public class RentBillRoyaltyDto : AopObject
    {
        /// <summary>
        /// 分账利息，单位元
        /// </summary>
        [XmlElement("actual_royalty_interest_price")]
        public string ActualRoyaltyInterestPrice { get; set; }

        /// <summary>
        /// 分账金额，单位元
        /// </summary>
        [XmlElement("actual_royalty_price")]
        public string ActualRoyaltyPrice { get; set; }

        /// <summary>
        /// 分账本金，单位元
        /// </summary>
        [XmlElement("actual_royalty_principal_price")]
        public string ActualRoyaltyPrincipalPrice { get; set; }

        /// <summary>
        /// 当前期数对应的阶梯买断分账金，单位元
        /// </summary>
        [XmlElement("current_buyout_price")]
        public string CurrentBuyoutPrice { get; set; }

        /// <summary>
        /// 关联分账履约单号
        /// </summary>
        [XmlElement("key_royalty_installment_no")]
        public string KeyRoyaltyInstallmentNo { get; set; }

        /// <summary>
        /// 还款期数
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 分账计划id
        /// </summary>
        [XmlElement("royalty_id")]
        public string RoyaltyId { get; set; }

        /// <summary>
        /// 分账状态
        /// </summary>
        [XmlElement("royalty_status")]
        public string RoyaltyStatus { get; set; }

        /// <summary>
        /// 还款阶段
        /// </summary>
        [XmlElement("stage")]
        public string Stage { get; set; }

        /// <summary>
        /// 还款资金类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
