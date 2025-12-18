using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitscopeQueryResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitscopeQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("activity_scope_list")]
        [XmlArrayItem("string")]
        public List<string> ActivityScopeList { get; set; }
    }
}
