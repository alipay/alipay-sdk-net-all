using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeUnifiedsettleSyncResponse.
    /// </summary>
    public class AlipayTradeUnifiedsettleSyncResponse : AopResponse
    {
        /// <summary>
        /// 订单同步受理单号
        /// </summary>
        [XmlElement("order_sync_id")]
        public string OrderSyncId { get; set; }

        /// <summary>
        /// 外部流水号。由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端单笔交易维度不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单处理状态，PROCESSING为处理中，SUCCESS为处理成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
