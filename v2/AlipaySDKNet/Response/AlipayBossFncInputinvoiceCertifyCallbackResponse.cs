using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputinvoiceCertifyCallbackResponse.
    /// </summary>
    public class AlipayBossFncInputinvoiceCertifyCallbackResponse : AopResponse
    {
        /// <summary>
        /// 勾选结果
        /// </summary>
        [XmlElement("result_set")]
        public InputInvoiceResponse ResultSet { get; set; }
    }
}
