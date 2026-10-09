using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubPackageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubPackageInfo : AopObject
    {
        /// <summary>
        /// 构建好的结果地址
        /// </summary>
        [XmlElement("builded_package_url")]
        public string BuildedPackageUrl { get; set; }

        /// <summary>
        /// 构建好的分包地址
        /// </summary>
        [XmlElement("new_builded_package_url")]
        public string NewBuildedPackageUrl { get; set; }

        /// <summary>
        /// 2.0分包大小，单位字节
        /// </summary>
        [XmlElement("new_size")]
        public string NewSize { get; set; }

        /// <summary>
        /// 分包路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 分包大小，单位字节
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 源码地址
        /// </summary>
        [XmlElement("source_url")]
        public string SourceUrl { get; set; }

        /// <summary>
        /// 分包类型： MAIN ｜ SUB
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
