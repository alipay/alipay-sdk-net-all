using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherTemplate : AopObject
    {
        /// <summary>
        /// 券可使用时间规则
        /// </summary>
        [XmlArray("available_time_rule")]
        [XmlArrayItem("voucher_time_rule")]
        public List<VoucherTimeRule> AvailableTimeRule { get; set; }

        /// <summary>
        /// 时间类型： 绝对时间(ABSOLUTE)，相对时间(RELATIVE)， 相对时间按天(RELATIVE_BY_DAY)
        /// </summary>
        [XmlElement("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// 券可使用过期时间： 1）绝对时间，格式为：yyyy-MM-dd HH:mm:ss 2）相对时间，格式为：N，如100，即相对于领取时间之后的分钟数 3）相对时间按天，格式为：N，如100，即相对于领取时间当日0点之后的分钟数
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 单品券信息
        /// </summary>
        [XmlElement("item_info")]
        public VoucherSingleItemInfo ItemInfo { get; set; }

        /// <summary>
        /// 优惠规则： 1）满减类型：券面额  2）折扣类型：折扣；单次封顶优惠金额 3）减至类型：减至金额
        /// </summary>
        [XmlElement("promo_info")]
        public PromoInfo PromoInfo { get; set; }

        /// <summary>
        /// 优惠类型： 代金(FIX),折扣(DISCOUNT),减至(SPECIAL)
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 券可使用开始时间： 1）绝对时间，格式为：yyyy-MM-dd HH:mm:ss 2）相对时间，格式为：N，如100，即相对于领取时间之后的分钟数 3）相对时间按天，格式为：N，如100，即相对于领取时间当日0点之后的分钟数
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
        /// 优惠券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券总张数
        /// </summary>
        [XmlElement("voucher_quantity")]
        public string VoucherQuantity { get; set; }

        /// <summary>
        /// 券类型： 1）商家全场优惠券(ALIPAY_BIZ_VOUCHER) 2）商家单品优惠券(ALIPAY_COMMON_ITEM_VOUCHER)
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
