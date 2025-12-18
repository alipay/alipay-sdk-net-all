using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailBenefitscopeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailBenefitscopeQueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
