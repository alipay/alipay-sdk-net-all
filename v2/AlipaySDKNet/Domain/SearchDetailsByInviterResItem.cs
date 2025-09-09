using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchDetailsByInviterResItem Data Structure.
    /// </summary>
    [Serializable]
    public class SearchDetailsByInviterResItem : AopObject
    {
        /// <summary>
        /// 邀请单id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 邀请授权资源
        /// </summary>
        [XmlArray("resources")]
        [XmlArrayItem("auth_resource_content")]
        public List<AuthResourceContent> Resources { get; set; }
    }
}
