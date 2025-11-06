using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CertBillDetail : AopObject
    {
        /// <summary>
        /// 当前账单对应的凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 商家优惠，单位：元
        /// </summary>
        [XmlElement("merchant_discount")]
        public string MerchantDiscount { get; set; }

        /// <summary>
        /// 券的原售价，单位：元
        /// </summary>
        [XmlElement("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 平台优惠，单位：元
        /// </summary>
        [XmlElement("platform_discount")]
        public string PlatformDiscount { get; set; }

        /// <summary>
        /// 用户实付，单位：元
        /// </summary>
        [XmlElement("real_pay")]
        public string RealPay { get; set; }

        /// <summary>
        /// 券的销售价格，单位：元
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 实际结算金额，单位：元
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// settle_type 为“USE”：代表“结算时间” settle_type为“REFUND”：代表“退结算时间”
        /// </summary>
        [XmlElement("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// 当前账单的结算类型
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 总三方分账金额（saas服务商佣金、待运营服务商佣金 等），单位：元
        /// </summary>
        [XmlElement("total_alloc_amount")]
        public string TotalAllocAmount { get; set; }

        /// <summary>
        /// 总抽佣金额（支付宝平台抽佣金额），单位：元
        /// </summary>
        [XmlElement("total_commission_amount")]
        public string TotalCommissionAmount { get; set; }

        /// <summary>
        /// settle_type 为“USE”：代表“核销时间” settle_type为“REFUND”：代表“退款时间”
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 核销的门店id
        /// </summary>
        [XmlElement("use_shop_id")]
        public string UseShopId { get; set; }
    }
}
