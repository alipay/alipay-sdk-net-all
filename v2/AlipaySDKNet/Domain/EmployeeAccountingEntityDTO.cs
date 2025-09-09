using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeAccountingEntityDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeAccountingEntityDTO : AopObject
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
    }
}
