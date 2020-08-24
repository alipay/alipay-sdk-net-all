using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntcommonwealDonateConsumeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntcommonwealDonateConsumeSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 核算完成时间，如果不填则默认不当前时间
        /// </summary>
        [XmlElement("gmt_trade_finished")]
        public string GmtTradeFinished { get; set; }

        /// <summary>
        /// 外部商户Id
        /// </summary>
        [XmlElement("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 外部交易账号
        /// </summary>
        [XmlElement("platform_trade_no")]
        public string PlatformTradeNo { get; set; }

        /// <summary>
        /// 捐赠产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 商家uid或协议
        /// </summary>
        [XmlElement("seller_user_id")]
        public string SellerUserId { get; set; }

        /// <summary>
        /// 平台来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 以分为单位，1001即10.01元
        /// </summary>
        [XmlElement("trade_amount")]
        public long TradeAmount { get; set; }

        /// <summary>
        /// 交易发起用户
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
