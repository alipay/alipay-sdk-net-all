using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniReleaststBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniReleaststBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("des")]
        public GavintestNewLeveaOne Des { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [XmlElement("out")]
        public string Out { get; set; }
    }
}
