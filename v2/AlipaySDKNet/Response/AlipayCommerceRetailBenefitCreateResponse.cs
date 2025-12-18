using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitCreateResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitCreateResponse : AopResponse
    {
        /// <summary>
        /// 新建的活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
