using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePrecreateConfirmResponse.
    /// </summary>
    public class AlipayTradePrecreateConfirmResponse : AopResponse
    {
        /// <summary>
        /// 收单模式  银行代理收单，取值：bankAgentMode  平台直连收单，取值：  normalOrderMode
        /// </summary>
        [XmlElement("acquiring_mode")]
        public string AcquiringMode { get; set; }

        /// <summary>
        /// 该参数代表该笔交易购买者的资产渠道的路由标识，cngw代表走中国统一网关，空或者无改key则是网联
        /// </summary>
        [XmlElement("expect_channel_route")]
        public string ExpectChannelRoute { get; set; }

        /// <summary>
        /// 间联商户信息,若商户是间联商户则必选 格式为json
        /// </summary>
        [XmlElement("indirect_merchant_info")]
        public TradePrecreateConfirmIndirectMerchantInfo IndirectMerchantInfo { get; set; }

        /// <summary>
        /// 直连商户信息，当商户为直连商户会有非空的值 格式为json
        /// </summary>
        [XmlElement("merchant_info")]
        public TradePrecreateConfirmTradeMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 商户原始订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 线上SKA支持A+钱包支付定制url 主站无处理，仅转发
        /// </summary>
        [XmlElement("merchant_return_url")]
        public string MerchantReturnUrl { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单信息 格式为json
        /// </summary>
        [XmlElement("order_info")]
        public TradePrecreateConfirmOrderInfo OrderInfo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 预下单的码信息 格式为json
        /// </summary>
        [XmlElement("precreate_code_info")]
        public TradePrecreateConfirmPrecreateCodeInfo PrecreateCodeInfo { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 清算机构流水号（如网联流水号）
        /// </summary>
        [XmlElement("settle_serial_no")]
        public string SettleSerialNo { get; set; }

        /// <summary>
        /// 店铺信息 格式为json
        /// </summary>
        [XmlElement("store_info")]
        public TradePrecreateConfirmTradeStoreInfo StoreInfo { get; set; }

        /// <summary>
        /// 订单金额 币种：人民币 单位：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
