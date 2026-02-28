using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceCategorytemplateQueryResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceCategorytemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("attr_template")]
        [XmlArrayItem("axf_item_attr_template")]
        public List<AxfItemAttrTemplate> AttrTemplate { get; set; }
    }
}
