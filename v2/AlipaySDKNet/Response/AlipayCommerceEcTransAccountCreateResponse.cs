using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransAccountCreateResponse.
    /// </summary>
    public class AlipayCommerceEcTransAccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 资金专户账号ID
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }
    }
}
