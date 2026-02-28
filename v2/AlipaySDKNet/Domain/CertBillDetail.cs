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
        /// 平台接收商家核销请求后的核销处理时间
        /// </summary>
        [XmlElement("alipay_verify_time")]
        public string AlipayVerifyTime { get; set; }

        /// <summary>
        /// 支付宝平台的凭证ID。开发者可以通过凭证核销准备接口获取。
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 仅当商家自行发放的三方码情况下，非空
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 仅当商家通过请求门店创建接口同步门店信息时，非空
        /// </summary>
        [XmlElement("m_shop_id")]
        public string MShopId { get; set; }

        /// <summary>
        /// 商家请求同步凭证核销状态接口时传入，即同步凭证核销状态接口的请求参数out_biz_no
        /// </summary>
        [XmlElement("m_use_order_id")]
        public string MUseOrderId { get; set; }

        /// <summary>
        /// 表示商家出资补贴的优惠金额。单位：元
        /// </summary>
        [XmlElement("merchant_discount")]
        public string MerchantDiscount { get; set; }

        /// <summary>
        /// 平台订单号，表示券售卖订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 券的原售价，单位：元
        /// </summary>
        [XmlElement("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 表示平台出资补贴的优惠金额。单位：元
        /// </summary>
        [XmlElement("platform_discount")]
        public string PlatformDiscount { get; set; }

        /// <summary>
        /// 不包含商家、平台出资补贴优惠。单位：元
        /// </summary>
        [XmlElement("real_pay")]
        public string RealPay { get; set; }

        /// <summary>
        /// 券的销售价格，单位：元
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 券售卖场景
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }

        /// <summary>
        /// 当商家结算方式=结算到户，格式：支付宝账户|abc@alipay.com 当商家结算方式=结算到银行卡，格式：工商银行|****卡号末4位
        /// </summary>
        [XmlElement("settle_account")]
        public string SettleAccount { get; set; }

        /// <summary>
        /// 表示凭证核销后订单结算金额，未扣除平台技术服务费、三方交易佣金。单位：元
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// settle_type 为“USE”：代表“结算时间” settle_type 为“REFUND”：代表“退结算时间”
        /// </summary>
        [XmlElement("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// 账单流水类型
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 第三方交易佣金，如服务商代运营佣金。单位：元
        /// </summary>
        [XmlElement("total_alloc_amount")]
        public string TotalAllocAmount { get; set; }

        /// <summary>
        /// 平台技术服务费。单位：元
        /// </summary>
        [XmlElement("total_commission_amount")]
        public string TotalCommissionAmount { get; set; }

        /// <summary>
        /// settle_type 为“USE”：代表“核销时间” settle_type为“REFUND”：代表“退款时间” 当前字段已废弃(字段废弃，不建议使用)
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 券核销的蚂蚁门店ID
        /// </summary>
        [XmlElement("use_shop_id")]
        public string UseShopId { get; set; }

        /// <summary>
        /// 券核销的蚂蚁门店名称
        /// </summary>
        [XmlElement("use_shop_name")]
        public string UseShopName { get; set; }

        /// <summary>
        /// 商家请求凭证核销接口时传入的时间，即同步凭证核销状态接口中的请求参数biz_dt
        /// </summary>
        [XmlElement("verify_time")]
        public string VerifyTime { get; set; }
    }
}
