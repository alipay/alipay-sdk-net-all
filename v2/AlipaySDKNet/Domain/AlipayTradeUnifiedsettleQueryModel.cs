using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeUnifiedsettleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeUnifiedsettleQueryModel : AopObject
    {
        /// <summary>
        /// 收结易订单的单号，一般和外部商户订单号一一对应，可能对应多笔请求号、请求流水号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单同步受理时生成的单号，一般与外部商户流水号一一对应，标识唯一一次订单同步请求
        /// </summary>
        [XmlElement("order_sync_id")]
        public string OrderSyncId { get; set; }

        /// <summary>
        /// 请求流水号。由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端单笔交易维度不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 签约产品码，目前仅支持UNIFIED_SETTLE
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
