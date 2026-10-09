using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeTemplateResp Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeTemplateResp : AopObject
    {
        /// <summary>
        /// DESC模板详情列表
        /// </summary>
        [XmlArray("desc_template_detail")]
        [XmlArrayItem("creative_template_detail_res")]
        public List<CreativeTemplateDetailRes> DescTemplateDetail { get; set; }

        /// <summary>
        /// 图片或者视频模板详情列表
        /// </summary>
        [XmlArray("material_template_detail")]
        [XmlArrayItem("creative_template_detail_res")]
        public List<CreativeTemplateDetailRes> MaterialTemplateDetail { get; set; }

        /// <summary>
        /// 创意模版描述说明
        /// </summary>
        [XmlElement("template_desc")]
        public string TemplateDesc { get; set; }

        /// <summary>
        /// 创意模版id
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// TITLE模板详情列表
        /// </summary>
        [XmlArray("title_template_detail")]
        [XmlArrayItem("creative_template_detail_res")]
        public List<CreativeTemplateDetailRes> TitleTemplateDetail { get; set; }
    }
}
