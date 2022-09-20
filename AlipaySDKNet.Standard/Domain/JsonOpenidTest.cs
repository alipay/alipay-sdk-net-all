using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JsonOpenidTest Data Structure.
    /// </summary>
    [Serializable]
    public class JsonOpenidTest : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("jsonuid")]
        public string Jsonuid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
