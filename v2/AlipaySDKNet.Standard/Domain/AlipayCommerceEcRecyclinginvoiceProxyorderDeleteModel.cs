using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceProxyorderDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceProxyorderDeleteModel : AopObject
    {
        /// <summary>
        /// 服务商请求流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 代卖人收购单ID，推荐作为查询键。
        /// </summary>
        [XmlElement("proxy_order_id")]
        public string ProxyOrderId { get; set; }
    }
}
