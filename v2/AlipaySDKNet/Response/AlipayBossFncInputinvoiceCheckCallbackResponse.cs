using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputinvoiceCheckCallbackResponse.
    /// </summary>
    public class AlipayBossFncInputinvoiceCheckCallbackResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result_set")]
        public InputInvoiceResponse ResultSet { get; set; }
    }
}
