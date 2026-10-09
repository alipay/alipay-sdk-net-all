using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateRosterDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateRosterDetailQueryModel : AopObject
    {
        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 花名册ID
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }
    }
}
