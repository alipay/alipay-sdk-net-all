using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectrulesModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectrulesModifyResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
