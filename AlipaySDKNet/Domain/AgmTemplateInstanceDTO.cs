using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgmTemplateInstanceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AgmTemplateInstanceDTO : AopObject
    {
        /// <summary>
        /// 模板文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// html文件OSS路径
        /// </summary>
        [XmlElement("html_oss_url")]
        public string HtmlOssUrl { get; set; }

        /// <summary>
        /// HTML文件下载地址
        /// </summary>
        [XmlElement("html_preview_url")]
        public string HtmlPreviewUrl { get; set; }

        /// <summary>
        /// 模板实例id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// OSS文件路径
        /// </summary>
        [XmlElement("oss_url")]
        public string OssUrl { get; set; }

        /// <summary>
        /// 实例文件下载地址
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }
    }
}
