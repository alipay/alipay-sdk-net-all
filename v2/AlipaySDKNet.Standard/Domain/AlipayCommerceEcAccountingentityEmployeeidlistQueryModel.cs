using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAccountingentityEmployeeidlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAccountingentityEmployeeidlistQueryModel : AopObject
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

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
