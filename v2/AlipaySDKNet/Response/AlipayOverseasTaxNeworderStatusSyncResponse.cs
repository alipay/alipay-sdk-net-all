using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTaxNeworderStatusSyncResponse.
    /// </summary>
    public class AlipayOverseasTaxNeworderStatusSyncResponse : AopResponse
    {
        /// <summary>
        /// 纸质退税单号
        /// </summary>
        [XmlElement("doc_id")]
        public string DocId { get; set; }

        /// <summary>
        /// 支付宝退税单号
        /// </summary>
        [XmlElement("tax_order_no")]
        public string TaxOrderNo { get; set; }
    }
}
