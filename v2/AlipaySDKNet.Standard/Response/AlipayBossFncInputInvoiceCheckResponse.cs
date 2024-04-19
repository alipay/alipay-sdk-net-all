using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputInvoiceCheckResponse.
    /// </summary>
    public class AlipayBossFncInputInvoiceCheckResponse : AopResponse
    {
        /// <summary>
        /// 发票验真返回
        /// </summary>
        [XmlElement("result_set")]
        public InputInvoiceCheckResponse ResultSet { get; set; }
    }
}
