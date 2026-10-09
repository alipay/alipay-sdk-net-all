using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBpaasAppPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBpaasAppPublishModel : AopObject
    {
        /// <summary>
        /// 应用版本号, 要求为纯数字，如10.20.1.1等 必须4位
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// bpaas 应用id
        /// </summary>
        [XmlElement("bpaas_app_id")]
        public string BpaasAppId { get; set; }

        /// <summary>
        /// 应用版本变更记录
        /// </summary>
        [XmlElement("change_log")]
        public string ChangeLog { get; set; }

        /// <summary>
        /// 文件SHA256摘要信息
        /// </summary>
        [XmlElement("file_digest")]
        public string FileDigest { get; set; }

        /// <summary>
        /// 文件MD5值
        /// </summary>
        [XmlElement("file_md_5")]
        public string FileMd5 { get; set; }

        /// <summary>
        /// 应用包文件大小
        /// </summary>
        [XmlElement("package_file_size")]
        public long PackageFileSize { get; set; }

        /// <summary>
        /// 应用包下载地址，公开url
        /// </summary>
        [XmlElement("scm_download_url")]
        public string ScmDownloadUrl { get; set; }
    }
}
