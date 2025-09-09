using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorCouponSendResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorCouponSendResultDTO : AopObject
    {
        /// <summary>
        /// 渠道侧用户id
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 优惠券名称
        /// </summary>
        [XmlElement("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 优惠券id
        /// </summary>
        [XmlElement("coupon_no")]
        public string CouponNo { get; set; }

        /// <summary>
        /// 券类型，枚举值： 1-放款券 2-还款券
        /// </summary>
        [XmlElement("coupon_type")]
        public long CouponType { get; set; }

        /// <summary>
        /// 券有效期结束时间，时间戳毫秒
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 券有效期开始时间，时间戳毫秒
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }
    }
}
