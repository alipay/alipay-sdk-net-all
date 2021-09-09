using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoiceBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodInvoiceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 发票数据
        /// </summary>
        [XmlElement("result_set")]
        public InvoiceResponsePageDTO ResultSet { get; set; }
    }
}
