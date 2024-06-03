using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TipsAndUrl Data Structure.
    /// </summary>
    [Serializable]
    public class TipsAndUrl : AopObject
    {
        /// <summary>
        /// 跳转链接的提示语
        /// </summary>
        [XmlElement("tips")]
        public string Tips { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
