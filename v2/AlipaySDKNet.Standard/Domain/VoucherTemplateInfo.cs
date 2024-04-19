using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherTemplateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherTemplateInfo : AopObject
    {
        /// <summary>
        /// 面额。每张代金券可以抵扣的金额。币种为人民币，单位为元。该数值不小于0，小数点以后最多两位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 优惠封顶金额
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券不可用时间详细规则
        /// </summary>
        [XmlArray("disable_detail_periods")]
        [XmlArrayItem("time_period_rule")]
        public List<TimePeriodRule> DisableDetailPeriods { get; set; }

        /// <summary>
        /// 单品价格可以享受的折扣力度（如填写0.9就表示9折）。 该值大于等于0.1且小于1，小数点以后最多保留两位。
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 券优惠类型; DISCOUNT: 折扣 FIX: 代金
        /// </summary>
        [XmlElement("discount_calc_type")]
        public string DiscountCalcType { get; set; }

        /// <summary>
        /// 门槛金额
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 单品id列表, 单品券场景返回该字段
        /// </summary>
        [XmlArray("goods_id")]
        [XmlArrayItem("string")]
        public List<string> GoodsId { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券使用时间详细规则
        /// </summary>
        [XmlArray("usable_detail_period")]
        [XmlArrayItem("time_period_rule")]
        public List<TimePeriodRule> UsableDetailPeriod { get; set; }

        /// <summary>
        /// 券生效结束时间
        /// </summary>
        [XmlElement("usable_end_time")]
        public string UsableEndTime { get; set; }

        /// <summary>
        /// 券生效开始时间
        /// </summary>
        [XmlElement("usable_start_time")]
        public string UsableStartTime { get; set; }

        /// <summary>
        /// 时间类型 RELATIVE: 相对类型 RELATIVE_BY_DAY: 相对类型按天取整 ABSOLUTE:绝对类型
        /// </summary>
        [XmlElement("usable_time_type")]
        public string UsableTimeType { get; set; }

        /// <summary>
        /// 券使用说明
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 优惠券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 拟发行券的数量。单位为张。该数值是大于0的整数。
        /// </summary>
        [XmlElement("voucher_quantity")]
        public string VoucherQuantity { get; set; }

        /// <summary>
        /// 券类型; GLOBAL_MONEY_OFF_VOUCHER: 全场代金券, GLOBAL_DISCOUNT_VOUCHER: 全场折扣券, ITEM_MONEY_OFF_VOUCHER:单品代金券, ITEM_DISCOUNT_VOUCHER:单品折扣券
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
