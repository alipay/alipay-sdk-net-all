using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherItem Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherItem : AopObject
    {
        /// <summary>
        /// 过期时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 满减类型：券面额  折扣类型：折扣；单次封顶优惠金额  减至：减至金额
        /// </summary>
        [XmlElement("promo_info")]
        public PromoInfo PromoInfo { get; set; }

        /// <summary>
        /// 优惠类型，共三种。 代金(FIX),折扣(DISCOUNT),减至(SPECIAL)
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 发券时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 消费门槛
        /// </summary>
        [XmlElement("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券状态，共三种。 可用(ENABLED),不可用(DISABLED),删除(DELETE)
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 优惠归属为商家优惠时，优惠类型包括：商家全场券（ALIPAY_BIZ_VOUCHER）、单品优惠券(ALIPAY_COMMON_ITEM_VOUCHER)
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
