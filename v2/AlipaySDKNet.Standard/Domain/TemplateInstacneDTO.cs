using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateInstacneDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateInstacneDTO : AopObject
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// html oss文件key
        /// </summary>
        [XmlElement("html_oss_url")]
        public string HtmlOssUrl { get; set; }

        /// <summary>
        /// html文件预览地址
        /// </summary>
        [XmlElement("html_preview_url")]
        public string HtmlPreviewUrl { get; set; }

        /// <summary>
        /// 模版实例id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// oss 文件fileKey
        /// </summary>
        [XmlElement("oss_url")]
        public string OssUrl { get; set; }

        /// <summary>
        /// 预览地址
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("agm_tag_d_t_o")]
        public List<AgmTagDTO> Tags { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
