using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingRtaMerchantCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingRtaMerchantCallbackModel : AopObject
    {
        /// <summary>
        /// 活动id描述用户使用这个活动消耗预算，该活动必须是被场景侧曝光过的活动
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 用于分类统计
        /// </summary>
        [XmlElement("commodity_category")]
        public string CommodityCategory { get; set; }

        /// <summary>
        /// 分润额，单位元，精确到小数点后两位
        /// </summary>
        [XmlElement("dividend_amt")]
        public string DividendAmt { get; set; }

        /// <summary>
        /// mobile_sha_256标识用户唯一信息，通过用户手机号SHA256 哈希后获得
        /// </summary>
        [XmlElement("mobile_sha_256")]
        public string MobileSha256 { get; set; }

        /// <summary>
        /// 支付金额，用于标识用户支付的金额，单位元，精确到小数点后两位
        /// </summary>
        [XmlElement("payment_amt")]
        public string PaymentAmt { get; set; }

        /// <summary>
        /// 请求id，单笔订单唯一
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 资源位信息确定商户投放场景，由摩斯同学配置并分配给调用方
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 交易时间，订单发生的时间
        /// </summary>
        [XmlElement("trade_date")]
        public string TradeDate { get; set; }

        /// <summary>
        /// 支付宝交易号，用于摩斯与广告主对账，内容可以是银行流水交易号或者商户交易的唯一标识，
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易金额，标识本次订单的金额，单位元，精确到小数点后两位
        /// </summary>
        [XmlElement("trade_total_amt")]
        public string TradeTotalAmt { get; set; }

        /// <summary>
        /// 交易类型，暂只支持核销VERIFY
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
