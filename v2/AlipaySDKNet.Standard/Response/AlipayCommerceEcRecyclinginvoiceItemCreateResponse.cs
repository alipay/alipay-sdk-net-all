using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceItemCreateResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceItemCreateResponse : AopResponse
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("company_item_id")]
        public string CompanyItemId { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
