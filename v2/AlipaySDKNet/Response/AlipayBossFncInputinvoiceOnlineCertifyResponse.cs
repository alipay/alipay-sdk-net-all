using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputinvoiceOnlineCertifyResponse.
    /// </summary>
    public class AlipayBossFncInputinvoiceOnlineCertifyResponse : AopResponse
    {
        /// <summary>
        /// 勾选结果
        /// </summary>
        [XmlElement("result_set")]
        public InputInvoiceResponse ResultSet { get; set; }
    }
}
