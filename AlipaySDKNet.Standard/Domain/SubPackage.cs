using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubPackage Data Structure.
    /// </summary>
    [Serializable]
    public class SubPackage : AopObject
    {
        /// <summary>
        /// 构建结果地址
        /// </summary>
        [XmlElement("build_package_url")]
        public string BuildPackageUrl { get; set; }

        /// <summary>
        /// 分包路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 源码地址
        /// </summary>
        [XmlElement("source_url")]
        public string SourceUrl { get; set; }

        /// <summary>
        /// 分包的类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
