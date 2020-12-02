using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherTemplate : AopObject
    {
        /// <summary>
        /// 劵有效期时间类型 (绝对时间:ABSOLUTE 相对时间:RELATIVE)
        /// </summary>
        [XmlElement("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// 过期时间，绝对时间格式为：yyyy-MM-dd HH:mm:ss，相对时间格式为：20，为使用截止时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 满减类型：券面额  折扣类型：折扣；单次封顶优惠金额；  减至：减至金额；
        /// </summary>
        [XmlElement("promo_info")]
        public PromoInfo PromoInfo { get; set; }

        /// <summary>
        /// 优惠类型：代金\折扣\减至
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 发券时间，绝对时间格式为：yyyy-MM-dd HH:mm:ss，相对时间格式为：10，为使用开始时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 消费门槛金额
        /// </summary>
        [XmlElement("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 优惠券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 优惠归属为商家优惠时，优惠类型包括：商家全场券（ALIPAY_BIZ_VOUCHER）、单品优惠券(ALIPAY_COMMON_ITEM_VOUCHER)
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
