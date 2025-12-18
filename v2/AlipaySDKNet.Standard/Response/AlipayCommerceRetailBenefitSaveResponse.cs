using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitSaveResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitSaveResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
