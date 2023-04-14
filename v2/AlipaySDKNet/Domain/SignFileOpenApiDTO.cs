using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignFileOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SignFileOpenApiDTO : AopObject
    {
        /// <summary>
        /// String 文件名称（一个 业务单据号对应的多个用印文件名称要不一样）
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// http的oss地址
        /// </summary>
        [XmlElement("http_oss_url")]
        public string HttpOssUrl { get; set; }

        /// <summary>
        /// 文件oss地址
        /// </summary>
        [XmlElement("oss_url")]
        public string OssUrl { get; set; }
    }
}
