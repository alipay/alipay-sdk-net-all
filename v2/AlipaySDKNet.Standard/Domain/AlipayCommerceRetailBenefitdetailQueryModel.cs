using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailBenefitdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailBenefitdetailQueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
