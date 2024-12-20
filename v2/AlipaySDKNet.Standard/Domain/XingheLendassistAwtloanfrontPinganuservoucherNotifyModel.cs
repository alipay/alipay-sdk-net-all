using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistAwtloanfrontPinganuservoucherNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistAwtloanfrontPinganuservoucherNotifyModel : AopObject
    {
        /// <summary>
        /// 利息抵扣券核销时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("coupon_bind_time")]
        public string CouponBindTime { get; set; }

        /// <summary>
        /// 利息抵扣券过期时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("coupon_expire_time")]
        public string CouponExpireTime { get; set; }

        /// <summary>
        /// 平安侧利息抵扣券id
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 利息抵扣券发放时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("coupon_receive_time")]
        public string CouponReceiveTime { get; set; }

        /// <summary>
        /// 利息抵扣券状态：1-已发放，2-已核销，3-已过期
        /// </summary>
        [XmlElement("coupon_status")]
        public string CouponStatus { get; set; }

        /// <summary>
        /// 对应平安测的couponTemplateId券模板id
        /// </summary>
        [XmlElement("coupon_template_id")]
        public string CouponTemplateId { get; set; }

        /// <summary>
        /// VOUCHER_RECEIVE：券领取通知（用户优惠券领取后） VOUCHER_USE：券核销通知（用于优惠券核销后）
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 平安测的订单号orderNo
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 蚂蚁侧进行权益登记时传到平安侧的requestId
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 格式yyyy-MM-dd HH:mm:ss，对应平安侧的submitTime
        /// </summary>
        [XmlElement("submit_time")]
        public string SubmitTime { get; set; }
    }
}
