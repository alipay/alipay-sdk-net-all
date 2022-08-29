using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSaleModeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSaleModeInfo : AopObject
    {
        /// <summary>
        /// 资金托管方式
        /// </summary>
        [XmlElement("fund_custody_mode")]
        public string FundCustodyMode { get; set; }

        /// <summary>
        /// 是否支持优惠券过期后，自动退款给用户。 不填默认否，枚举值： true：是 false：否。自动退款功能需要服务商在优惠券过期时，主动调用alipay.marketing.activity.order.refund接口进行退款。 如果配置优惠券时选择了过期自动退款，但是实际券过期后，服务商没有进行退款，那么用户投诉后，需要服务商进行解决。
        /// </summary>
        [XmlElement("overdue_refundable")]
        public bool OverdueRefundable { get; set; }

        /// <summary>
        /// 收款账号。 目前的结算规则是，每核销一笔优惠券，支付宝会打款到该收款账户。
        /// </summary>
        [XmlElement("payee_pid")]
        public string PayeePid { get; set; }

        /// <summary>
        /// 购买的优惠券是否允许退款。 不填默认否，枚举值： true：是 false：否
        /// </summary>
        [XmlElement("refundable")]
        public bool Refundable { get; set; }

        /// <summary>
        /// 用户购买优惠券需要支付的金额
        /// </summary>
        [XmlElement("sale_amount")]
        public string SaleAmount { get; set; }

        /// <summary>
        /// 结算信息
        /// </summary>
        [XmlElement("settle_info")]
        public BizfundSettleInfo SettleInfo { get; set; }
    }
}
