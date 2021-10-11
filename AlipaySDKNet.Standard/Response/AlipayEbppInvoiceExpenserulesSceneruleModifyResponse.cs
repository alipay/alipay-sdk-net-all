using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesSceneruleModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesSceneruleModifyResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
