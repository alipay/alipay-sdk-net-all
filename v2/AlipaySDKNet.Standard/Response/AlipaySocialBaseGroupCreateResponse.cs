using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseGroupCreateResponse.
    /// </summary>
    public class AlipaySocialBaseGroupCreateResponse : AopResponse
    {
        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
