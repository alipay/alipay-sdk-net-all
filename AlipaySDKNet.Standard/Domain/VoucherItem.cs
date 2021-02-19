using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherItem Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherItem : AopObject
    {
        /// <summary>
        /// 券可使用时间规则
        /// </summary>
        [XmlArray("available_time_rule")]
        [XmlArrayItem("voucher_time_rule")]
        public List<VoucherTimeRule> AvailableTimeRule { get; set; }

        /// <summary>
        /// 券可使用过期时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 单品券商品信息
        /// </summary>
        [XmlElement("item_info")]
        public VoucherSingleItemInfo ItemInfo { get; set; }

        /// <summary>
        /// 优惠规则： 1）满减类型：券面额  2）折扣类型：折扣；单次封顶优惠金额 3）减至类型：减至金额
        /// </summary>
        [XmlElement("promo_info")]
        public PromoInfo PromoInfo { get; set; }

        /// <summary>
        /// 优惠类型，共三种。 代金(FIX),折扣(DISCOUNT),减至(SPECIAL)
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 用户领取时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 券可使用开始时间，格式为yyyy-MM-dd HH:mm:ss
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
        /// 券不可使用时间规则
        /// </summary>
        [XmlArray("unavailable_time_rule")]
        [XmlArrayItem("voucher_time_rule")]
        public List<VoucherTimeRule> UnavailableTimeRule { get; set; }

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
        /// 券状态： 可用(ENABLED)，已核销(即完全使用，USED)，已过期(EXPIRED)，删除(DELETE)，不可用(DISABLED，逐步废弃)
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 券类型： 1）商家全场优惠券(ALIPAY_BIZ_VOUCHER) 2）商家单品优惠券(ALIPAY_COMMON_ITEM_VOUCHER)
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
