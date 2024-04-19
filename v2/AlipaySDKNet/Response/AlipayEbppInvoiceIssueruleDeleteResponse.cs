using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceIssueruleDeleteResponse.
    /// </summary>
    public class AlipayEbppInvoiceIssueruleDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
