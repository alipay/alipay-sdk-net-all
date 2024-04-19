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
        /// 门槛金额。说明：该字段可不填，认为无门槛;
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 是否支持优惠券过期后，自动退款给用户。 不填默认否，枚举值： true：是 false：否  自动退款功能需要服务商在优惠券过期时，主动调用alipay.marketing.activity.order.refund接口进行退款。  如果配置优惠券时选择了过期自动退款，但是实际券过期后，服务商没有进行退款，那么用户投诉后，需要服务商进行解决。
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
