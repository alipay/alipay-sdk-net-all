using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAccountingentityCreateResponse.
    /// </summary>
    public class AlipayCommerceEcAccountingentityCreateResponse : AopResponse
    {
        /// <summary>
        /// 核算主体id
        /// </summary>
        [XmlElement("accounting_entity_id")]
        public string AccountingEntityId { get; set; }
    }
}
