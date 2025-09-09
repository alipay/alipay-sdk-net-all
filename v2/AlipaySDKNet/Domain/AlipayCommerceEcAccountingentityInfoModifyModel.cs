using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAccountingentityInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAccountingentityInfoModifyModel : AopObject
    {
        /// <summary>
        /// 核算主体编码
        /// </summary>
        [XmlElement("accounting_entity_code")]
        public string AccountingEntityCode { get; set; }

        /// <summary>
        /// 核算主体id
        /// </summary>
        [XmlElement("accounting_entity_id")]
        public string AccountingEntityId { get; set; }

        /// <summary>
        /// 核算主体名称
        /// </summary>
        [XmlElement("accounting_entity_name")]
        public string AccountingEntityName { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
