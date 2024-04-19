using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpLeadsExpandCreateResponse.
    /// </summary>
    public class AlipayOpenSpLeadsExpandCreateResponse : AopResponse
    {
        /// <summary>
        /// 商机id
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }
    }
}
