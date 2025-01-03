using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

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

        /// <summary>
        /// 资金专户外表卡信息
        /// </summary>
        [XmlElement("account_card_info")]
        public TransInCardInfo AccountCardInfo { get; set; }
    }
}
