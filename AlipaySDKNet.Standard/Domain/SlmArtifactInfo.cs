using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SlmArtifactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SlmArtifactInfo : AopObject
    {
        /// <summary>
        /// 图片名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 图片大小
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("uri")]
        public string Uri { get; set; }
    }
}
