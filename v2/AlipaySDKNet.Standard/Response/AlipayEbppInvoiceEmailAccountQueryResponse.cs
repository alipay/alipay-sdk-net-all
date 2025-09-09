using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEmailAccountQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEmailAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 收票邮箱地址
        /// </summary>
        [XmlElement("email_address")]
        public string EmailAddress { get; set; }
    }
}
