using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateInstDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateInstDTO : AopObject
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// html的oss地址
        /// </summary>
        [XmlElement("html_oss_url")]
        public string HtmlOssUrl { get; set; }

        /// <summary>
        /// html预览地址
        /// </summary>
        [XmlElement("html_preview_url")]
        public string HtmlPreviewUrl { get; set; }

        /// <summary>
        /// 模版实例id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// word的oss地址
        /// </summary>
        [XmlElement("oss_url")]
        public string OssUrl { get; set; }

        /// <summary>
        /// word预览地址
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }
    }
}
