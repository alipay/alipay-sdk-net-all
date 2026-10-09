using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceProxyorderCreateResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceProxyorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 农户授权链接，服务商用于生成或展示授权二维码。
        /// </summary>
        [XmlElement("auth_url")]
        public string AuthUrl { get; set; }

        /// <summary>
        /// 服务商侧外部流水单号，原样返回。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 代卖人收购单ID。
        /// </summary>
        [XmlElement("proxy_order_id")]
        public string ProxyOrderId { get; set; }

        /// <summary>
        /// 收购单状态，创建成功后为NOT_CONFIRMED。
        /// </summary>
        [XmlElement("proxy_order_status")]
        public string ProxyOrderStatus { get; set; }
    }
}
