using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUploadResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionUploadResponse : AopResponse
    {
        /// <summary>
        /// 构建信息
        /// </summary>
        [XmlElement("build_info")]
        public string BuildInfo { get; set; }

        /// <summary>
        /// 包地址
        /// </summary>
        [XmlElement("build_package_url")]
        public string BuildPackageUrl { get; set; }

        /// <summary>
        /// 构建状态
        /// </summary>
        [XmlElement("build_status")]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 构建版本
        /// </summary>
        [XmlElement("build_version")]
        public string BuildVersion { get; set; }

        /// <summary>
        /// 是否需要轮询
        /// </summary>
        [XmlElement("need_rotation")]
        public string NeedRotation { get; set; }

        /// <summary>
        /// 包管理包ID
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }

        /// <summary>
        /// 版本创建结果
        /// </summary>
        [XmlElement("version_created")]
        public string VersionCreated { get; set; }
    }
}
