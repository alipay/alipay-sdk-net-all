using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterQrcodeQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterQrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 推广码链接
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
