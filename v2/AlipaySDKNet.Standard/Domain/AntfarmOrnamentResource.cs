using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfarmOrnamentResource Data Structure.
    /// </summary>
    [Serializable]
    public class AntfarmOrnamentResource : AopObject
    {
        /// <summary>
        /// 3d装扮资源信息
        /// </summary>
        [XmlElement("resource_for_3_d")]
        public string ResourceFor3D { get; set; }

        /// <summary>
        /// 2d装扮资源信息
        /// </summary>
        [XmlElement("resource_for_spine")]
        public string ResourceForSpine { get; set; }

        /// <summary>
        /// 2d装扮静态图资源
        /// </summary>
        [XmlElement("resource_for_static_image")]
        public string ResourceForStaticImage { get; set; }

        /// <summary>
        /// 蚂蚁庄园装扮资源key
        /// </summary>
        [XmlElement("resource_key")]
        public string ResourceKey { get; set; }
    }
}
