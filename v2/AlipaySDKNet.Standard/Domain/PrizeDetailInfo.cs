using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeDetailInfo : AopObject
    {
        /// <summary>
        /// 优惠券信息
        /// </summary>
        [XmlArray("coupon_info")]
        [XmlArrayItem("coupon_info")]
        public List<CouponInfo> CouponInfo { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }
    }
}
