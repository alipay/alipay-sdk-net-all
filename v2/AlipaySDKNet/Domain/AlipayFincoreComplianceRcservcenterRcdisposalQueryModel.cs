using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcservcenterRcdisposalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcservcenterRcdisposalQueryModel : AopObject
    {
        /// <summary>
        /// 需求code
        /// </summary>
        [XmlElement("demand_code")]
        public string DemandCode { get; set; }

        /// <summary>
        /// 主体id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }
    }
}
