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
        /// 买断分账金，人明币，单位：元
        /// </summary>
        [XmlElement("buy_out_royalty")]
        public string BuyOutRoyalty { get; set; }

        /// <summary>
        /// 预期分账时间
        /// </summary>
        [XmlElement("expect_royalty_time")]
        public string ExpectRoyaltyTime { get; set; }

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
        /// 分账类型
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }
    }
}
