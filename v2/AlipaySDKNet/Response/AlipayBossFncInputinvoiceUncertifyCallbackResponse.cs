using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputinvoiceUncertifyCallbackResponse.
    /// </summary>
    public class AlipayBossFncInputinvoiceUncertifyCallbackResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result_set")]
        public InputInvoiceResponse ResultSet { get; set; }
    }
}
