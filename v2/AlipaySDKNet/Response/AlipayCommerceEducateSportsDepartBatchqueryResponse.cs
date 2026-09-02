using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsDepartBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsDepartBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("sports_department")]
        public List<SportsDepartment> List { get; set; }
    }
}
