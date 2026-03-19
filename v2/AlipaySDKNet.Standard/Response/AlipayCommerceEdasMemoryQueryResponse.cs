using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEdasMemoryQueryResponse.
    /// </summary>
    public class AlipayCommerceEdasMemoryQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("user_labels")]
        [XmlArrayItem("user_labels")]
        public List<UserLabels> UserLabels { get; set; }
    }
}
