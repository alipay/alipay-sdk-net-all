using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExchangeVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExchangeVoucherInfo : AopObject
    {
        /// <summary>
        /// 券的价值
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 兑换券业务类型。 注意：兑换券通过大促活动权益报名能力推广至支付宝会场时，本参数必填。
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 兑换商品信息
        /// </summary>
        [XmlElement("exchange_goods_info")]
        public VoucherExchangeGoodsInfo ExchangeGoodsInfo { get; set; }

        /// <summary>
        /// 优惠门槛金额，表示只有当订单金额大于等于门槛金额时券才能使用。该字段为空时表示无门槛。 门槛金额的校验由服务商(商户)核销时自行校验，支付宝侧只做展示使用。
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 优惠门槛信息
        /// </summary>
        [XmlElement("voucher_deduct_threshold_info")]
        public VoucherDeductThresholdInfo VoucherDeductThresholdInfo { get; set; }
    }
}
