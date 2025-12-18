using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnchorInstance Data Structure.
    /// </summary>
    [Serializable]
    public class AnchorInstance : AopObject
    {
        /// <summary>
        /// 锚定物ID
        /// </summary>
        [XmlElement("anchor_id")]
        public string AnchorId { get; set; }

        /// <summary>
        /// 锚定物实例ID
        /// </summary>
        [XmlElement("anchor_instance_id")]
        public string AnchorInstanceId { get; set; }
    }
}
