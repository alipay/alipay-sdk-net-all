using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExchangeVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class ExchangeVoucher : AopObject
    {
        /// <summary>
        /// 券的价值
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 兑换券业务类型。
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [XmlElement("customer_service_mobile")]
        public string CustomerServiceMobile { get; set; }

        /// <summary>
        /// 客服链接
        /// </summary>
        [XmlElement("customer_service_url")]
        public string CustomerServiceUrl { get; set; }

        /// <summary>
        /// 优惠门槛金额，表示只有当订单金额大于等于门槛金额时券才能使用。该字段为空时表示无门槛。 门槛金额的校验由服务商(商户)核销时自行校验，支付宝侧只做展示使用。
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 是否支持优惠券过期后，自动退款给用户。 不填默认否，枚举值： true：是 false：否
        /// </summary>
        [XmlElement("overdue_refundable")]
        public bool OverdueRefundable { get; set; }

        /// <summary>
        /// 收款账号。目前的结算规则是，每核销一笔优惠券，支付宝会打款到该收款账户。
        /// </summary>
        [XmlElement("payee_pid")]
        public string PayeePid { get; set; }

        /// <summary>
        /// 购买的优惠券是否允许退款。不填默认否，枚举值： true：是 false：否
        /// </summary>
        [XmlElement("refundable")]
        public bool Refundable { get; set; }

        /// <summary>
        /// 用户购买优惠券需要支付的金额
        /// </summary>
        [XmlElement("sale_amount")]
        public string SaleAmount { get; set; }

        /// <summary>
        /// 1.账期模式:走默认结算账号 2.分账模式:门店分账 3.分账模式:合作商户
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 领(购)券详情页链接，从支付宝公域跳转到服务商(商户)自定义领(购)券详情页。
        /// </summary>
        [XmlElement("voucher_detail_url")]
        public string VoucherDetailUrl { get; set; }

        /// <summary>
        /// 对消费者展示的券(商品)名称。
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }
    }
}
