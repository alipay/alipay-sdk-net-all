using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingSrtaNanonymousCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingSrtaNanonymousCallbackModel : AopObject
    {
        /// <summary>
        /// 活动唯一标识，由查询接口返回
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 优惠金额，单位元
        /// </summary>
        [XmlElement("discount_amt")]
        public string DiscountAmt { get; set; }

        /// <summary>
        /// 扩展备用参数，正常情况下不需要填写,json格式
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 明文手机号，与mobile_sha_256两者选其一
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 手机号 hash后的值，与mobile两者选其一
        /// </summary>
        [XmlElement("mobile_sha_256")]
        public string MobileSha256 { get; set; }

        /// <summary>
        /// 交易时间，格式yyyy-MM-dd hh:mm:ss
        /// </summary>
        [XmlElement("trade_create_date")]
        public string TradeCreateDate { get; set; }

        /// <summary>
        /// 用于摩斯与广告主对账，内容可以是银行流水交易号或者商户交易的唯一标识
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易金额，单位元
        /// </summary>
        [XmlElement("trade_total_amt")]
        public string TradeTotalAmt { get; set; }
    }
}
