using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUploadstatusQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionUploadstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 构建信息
        /// </summary>
        [XmlElement("build_info")]
        public string BuildInfo { get; set; }

        /// <summary>
        /// 构建好的包地址
        /// </summary>
        [XmlElement("build_package_url")]
        public string BuildPackageUrl { get; set; }

        /// <summary>
        /// 构建状态
        /// </summary>
        [XmlElement("build_status")]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 构建日志地址
        /// </summary>
        [XmlElement("log_url")]
        public string LogUrl { get; set; }

        /// <summary>
        /// 是否需要轮询
        /// </summary>
        [XmlElement("need_rotation")]
        public string NeedRotation { get; set; }

        /// <summary>
        /// 构建的结果地址
        /// </summary>
        [XmlElement("result_url")]
        public string ResultUrl { get; set; }

        /// <summary>
        /// 创建版本结果
        /// </summary>
        [XmlElement("version_created")]
        public string VersionCreated { get; set; }
    }
}
