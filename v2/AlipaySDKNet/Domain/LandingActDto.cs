using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LandingActDto Data Structure.
    /// </summary>
    [Serializable]
    public class LandingActDto : AopObject
    {
        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 活动值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
