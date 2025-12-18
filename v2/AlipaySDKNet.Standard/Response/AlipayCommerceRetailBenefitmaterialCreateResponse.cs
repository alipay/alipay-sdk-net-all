using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitmaterialCreateResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitmaterialCreateResponse : AopResponse
    {
        /// <summary>
        /// 素材id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
