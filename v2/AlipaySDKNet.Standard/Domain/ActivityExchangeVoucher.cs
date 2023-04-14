using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityExchangeVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityExchangeVoucher : AopObject
    {
        /// <summary>
        /// 券的价值。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 优惠门槛金额，表示只有当订单金额大于等于门槛金额时券才能使用。该字段为空时表示无门槛。 门槛金额的校验由服务商(商户)核销时自行校验，支付宝侧只做展示使用。 币种为人民币，单位为元。小数点以后最多保留两位。 设置门槛：取值范围:0.1<=x<= 50000。如果设置了门槛金额，则必须大于等于0.1，不可以等于0。
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 是否支持优惠券过期后，自动退款给用户。 不填默认否，枚举值： true：是 false：否 自动退款功能需要服务商在优惠券过期时，主动调用alipay.marketing.activity.order.refund接口进行退款。 如果配置优惠券时选择了过期自动退款，但是实际券过期后，服务商没有进行退款，那么用户投诉后，需要服务商进行解决。
        /// </summary>
        [XmlElement("overdue_refundable")]
        public bool OverdueRefundable { get; set; }

        /// <summary>
        /// 购买的优惠券是否允许退款。 不填默认否，枚举值： true：是 false：否
        /// </summary>
        [XmlElement("refundable")]
        public bool Refundable { get; set; }

        /// <summary>
        /// 用户购买优惠券需要支付的金额。
        /// </summary>
        [XmlElement("sale_amount")]
        public string SaleAmount { get; set; }
    }
}
