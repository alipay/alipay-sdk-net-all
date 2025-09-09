using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAccountingentityDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAccountingentityDeleteModel : AopObject
    {
        /// <summary>
        /// 核算主体id
        /// </summary>
        [XmlElement("accounting_entity_id")]
        public string AccountingEntityId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
