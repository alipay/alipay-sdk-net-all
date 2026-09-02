using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsWhitetypeBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsWhitetypeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("white_type_item")]
        public List<WhiteTypeItem> List { get; set; }
    }
}
