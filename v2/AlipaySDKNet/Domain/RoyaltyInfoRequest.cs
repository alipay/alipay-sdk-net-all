using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoyaltyInfoRequest Data Structure.
    /// </summary>
    [Serializable]
    public class RoyaltyInfoRequest : AopObject
    {
        /// <summary>
        /// 买断分账金，人民币，单位：元
        /// </summary>
        [XmlElement("buy_out_royalty")]
        public string BuyOutRoyalty { get; set; }

        /// <summary>
        /// 买断分账利息，人民币，单位：元
        /// </summary>
        [XmlElement("buy_out_royalty_interest_price")]
        public string BuyOutRoyaltyInterestPrice { get; set; }

        /// <summary>
        /// 买断分账本金，人民币，单位：元
        /// </summary>
        [XmlElement("buy_out_royalty_principal_price")]
        public string BuyOutRoyaltyPrincipalPrice { get; set; }

        /// <summary>
        /// 预期分账时间
        /// </summary>
        [XmlElement("expect_royalty_time")]
        public string ExpectRoyaltyTime { get; set; }

        /// <summary>
        /// 应还日（资方）
        /// </summary>
        [XmlElement("repay_time")]
        public string RepayTime { get; set; }

        /// <summary>
        /// 计息时间，到天维度即可，例如2025-05-12
        /// </summary>
        [XmlElement("royalty_interest_date")]
        public string RoyaltyInterestDate { get; set; }

        /// <summary>
        /// 分账利息，币种：人民币。
        /// </summary>
        [XmlElement("royalty_interest_price")]
        public string RoyaltyInterestPrice { get; set; }

        /// <summary>
        /// 分账期数
        /// </summary>
        [XmlElement("royalty_period")]
        public string RoyaltyPeriod { get; set; }

        /// <summary>
        /// 分账金额，单位为元；
        /// </summary>
        [XmlElement("royalty_price")]
        public string RoyaltyPrice { get; set; }

        /// <summary>
        /// 分账本金，币种:人民币
        /// </summary>
        [XmlElement("royalty_principal_price")]
        public string RoyaltyPrincipalPrice { get; set; }

        /// <summary>
        /// 分账类型
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }
    }
}
