using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenidTestAll Data Structure.
    /// </summary>
    [Serializable]
    public class OpenidTestAll : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("json")]
        public JsonOpenidTest Json { get; set; }

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
