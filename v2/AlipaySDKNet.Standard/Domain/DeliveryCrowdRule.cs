using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryCrowdRule Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryCrowdRule : AopObject
    {
        /// <summary>
        /// 指定人群ID
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }
    }
}
