using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehActivityItem Data Structure.
    /// </summary>
    [Serializable]
    public class VehActivityItem : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
