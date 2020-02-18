using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMemberDataDesdBatchqueryResponse.
    /// </summary>
    public class KoubeiMemberDataDesdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("de")]
        public GavintestNewonline De { get; set; }
    }
}
