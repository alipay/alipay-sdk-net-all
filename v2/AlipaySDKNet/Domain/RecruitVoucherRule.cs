using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitVoucherRule Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitVoucherRule : AopObject
    {
        /// <summary>
        /// 券面额（每张代金券可以抵扣的金额）的的最大值。 币种为人民币，单位为元。小数点以后最多保留两位。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("amount_max")]
        public string AmountMax { get; set; }

        /// <summary>
        /// 券面额（每张代金券可以抵扣的金额）的最小值。 币种为人民币，单位为元。小数点以后最多保留两位。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("amount_min")]
        public string AmountMin { get; set; }

        /// <summary>
        /// 券优惠比例的最大值。20代表优惠比例最多是20%。券优惠券比例=券优惠面额/门槛金额。 浮点类型，取值范围为[1,100]，左右均是闭区间，小数点以后最多保留两位。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("denomination_percent_max")]
        public string DenominationPercentMax { get; set; }

        /// <summary>
        /// 券优惠比例的最小值。10代表优惠比例最少是10%。券优惠券比例=券优惠面额/门槛金额。 浮点类型，取值范围为[1,100]，左右均是闭区间，小数点以后最多保留两位。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("denomination_percent_min")]
        public string DenominationPercentMin { get; set; }

        /// <summary>
        /// 券门槛金额的最大值。 币种为人民币，单位为元。小数点以后最多保留两位。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("floor_amount_max")]
        public string FloorAmountMax { get; set; }

        /// <summary>
        /// 券门槛金额的最小值。 币种为人民币，单位为元。小数点以后最多保留两位。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("floor_amount_min")]
        public string FloorAmountMin { get; set; }

        /// <summary>
        /// 券原价的最大值。 币种为人民币，单位为元。小数点以后最多保留两位。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("origin_amount_max")]
        public string OriginAmountMax { get; set; }

        /// <summary>
        /// 券原价的最小值。 币种为人民币，单位为元。小数点以后最多保留两位。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("origin_amount_min")]
        public string OriginAmountMin { get; set; }

        /// <summary>
        /// 券发放结束时间的最大值。 格式为：yyyy-MM-dd HH:mm:ss 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("publish_end_time_max")]
        public string PublishEndTimeMax { get; set; }

        /// <summary>
        /// 券发放结束时间的最小值。 格式为：yyyy-MM-dd HH:mm:ss 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("publish_end_time_min")]
        public string PublishEndTimeMin { get; set; }

        /// <summary>
        /// 券发放开始时间的最大值。 格式为：yyyy-MM-dd HH:mm:ss 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("publish_start_time_max")]
        public string PublishStartTimeMax { get; set; }

        /// <summary>
        /// 券发放开始时间的最小值。 格式为：yyyy-MM-dd HH:mm:ss 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("publish_start_time_min")]
        public string PublishStartTimeMin { get; set; }

        /// <summary>
        /// 退券类型要求，列表，总共有两种类型： 过期退OVERDUE_REFUND 随时退CAN_REFUND 该字段为空时表示不限制。
        /// </summary>
        [XmlArray("refund_type")]
        [XmlArrayItem("string")]
        public List<string> RefundType { get; set; }

        /// <summary>
        /// 用户购买优惠券需要支付的金额的最大值。 币种为人民币，单位为元。小数点以后最多保留两位。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("sale_amount_max")]
        public string SaleAmountMax { get; set; }

        /// <summary>
        /// 用户购买优惠券需要支付的金额的最小值。 币种为人民币，单位为元。小数点以后最多保留两位。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("sale_amount_min")]
        public string SaleAmountMin { get; set; }

        /// <summary>
        /// 券核销渠道要求，列表，总共有两个渠道： 门店SHOP 小程序MINI_APP 该字段为空时表示不限制。
        /// </summary>
        [XmlArray("use_channel")]
        [XmlArrayItem("string")]
        public List<string> UseChannel { get; set; }

        /// <summary>
        /// 券生效后至少N天内可以使用。比如：valid_days_after_receive_min=20代表 券生效后至少20天内可以使用。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("valid_days_after_receive_min")]
        public long ValidDaysAfterReceiveMin { get; set; }

        /// <summary>
        /// 券活动类型。支持七种商家券类型和两种支付券类型。  枚举值： 商家券类型：  ALL_FIX_ORDER_VOUCHER 全场满减券；  ITEM_FIX_ORDER_VOUCHER 单品满减券；  ALL_DISCOUNT_ORDER_VOUCHER 全场折扣券；  ITEM_DISCOUNT_ORDER_VOUCHER 单品折扣券；  ITEM_SPE_ORDER_VOUCHER 单品特价券；  EXCHANGE_GROUP_BUY_ORDER_VOUCHER 兑换团购券；  EXCHANGE_FIX_ORDER_VOUCHER 兑换代金券；  支付券类型：  ALL_FIX_VOUCHER 全场满减券；  ITEM_FIX_VOUCHER 单品满减券；  创建商家券参考https://opendocs.alipay.com/apis/01xm17 创建支付券参考https://opendocs.alipay.com/pre-apis/027185（仅供受邀用户使用） 不同的创建券的参数创建出不同类型的券：  1. 根据voucher_type区分满减券、折扣券、特价券、兑换券  2. 根据goods_name是否为空区分单品券、全场券（当voucher_type为满减券、折扣券、特价券）  3. 根据voucher_use_rule.exchange_voucher.biz_type区分团购券、代金券（当voucher_type为兑换券）
        /// </summary>
        [XmlElement("voucher_activity_type")]
        public string VoucherActivityType { get; set; }

        /// <summary>
        /// 每人领取限制的最大值。 默认按照支付宝uid进行领取限制。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("voucher_quantity_limit_per_user_max")]
        public long VoucherQuantityLimitPerUserMax { get; set; }

        /// <summary>
        /// 每人领取限制的最小值。 默认按照支付宝uid进行领取限制。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("voucher_quantity_limit_per_user_min")]
        public long VoucherQuantityLimitPerUserMin { get; set; }

        /// <summary>
        /// 券库存数量的最大值。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("voucher_quantity_max")]
        public long VoucherQuantityMax { get; set; }

        /// <summary>
        /// 券库存数量的最小值。 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("voucher_quantity_min")]
        public long VoucherQuantityMin { get; set; }

        /// <summary>
        /// 券可使用的开始时间的最小值。 格式为：yyyy-MM-dd HH:mm:ss 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("voucher_valid_begin_time_min")]
        public string VoucherValidBeginTimeMin { get; set; }

        /// <summary>
        /// 券可使用的结束时间的最大值。 格式为：yyyy-MM-dd HH:mm:ss 该字段为空时表示不限制。
        /// </summary>
        [XmlElement("voucher_valid_end_time_max")]
        public string VoucherValidEndTimeMax { get; set; }
    }
}
