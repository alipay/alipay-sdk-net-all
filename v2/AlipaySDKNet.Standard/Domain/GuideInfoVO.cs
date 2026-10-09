using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GuideInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class GuideInfoVO : AopObject
    {
        /// <summary>
        /// 导购信息key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 导购信息value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
