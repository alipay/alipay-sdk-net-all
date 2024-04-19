using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractTemplateOpenVO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractTemplateOpenVO : AopObject
    {
        /// <summary>
        /// 企业印章类型矩形框组件可选。
        /// </summary>
        [XmlArray("corporate_seal_rects")]
        [XmlArrayItem("corporate_seal_rect_open_v_o")]
        public List<CorporateSealRectOpenVO> CorporateSealRects { get; set; }

        /// <summary>
        /// 多行文本组件框列表，可选。
        /// </summary>
        [XmlArray("multiline_text_rects")]
        [XmlArrayItem("multiline_text_rect_open_v_o")]
        public List<MultilineTextRectOpenVO> MultilineTextRects { get; set; }

        /// <summary>
        /// 是否必须阅读，非必填，增加解决方案时使用。
        /// </summary>
        [XmlElement("must_read")]
        public bool MustRead { get; set; }

        /// <summary>
        /// 个人印章组件框，可选。
        /// </summary>
        [XmlArray("personal_seal_rects")]
        [XmlArrayItem("personal_seal_rect_open_v_o")]
        public List<PersonalSealRectOpenVO> PersonalSealRects { get; set; }

        /// <summary>
        /// 文件预览URL，唯一值，由系统生成。
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 单行文本组件框列表
        /// </summary>
        [XmlArray("singleline_text_rects")]
        [XmlArrayItem("multiline_text_rect_open_v_o")]
        public List<MultilineTextRectOpenVO> SinglelineTextRects { get; set; }

        /// <summary>
        /// 合同模板ID，如果存在则为唯一值，由系统生成，在保存成功后会返回该值。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 合同模板描述，非唯一值，由用户自己输入。
        /// </summary>
        [XmlElement("template_memo")]
        public string TemplateMemo { get; set; }

        /// <summary>
        /// 合同模板名称，非唯一值，由用户自行输入。
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板来源，可选，根据模板来源信息获取方式不同，openapi 默认AFTS_FILE。
        /// </summary>
        [XmlElement("template_source")]
        public string TemplateSource { get; set; }

        /// <summary>
        /// 合同模板文件类型，用于区分文件类型。
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }

        /// <summary>
        /// 时间组件框，可选。
        /// </summary>
        [XmlArray("time_stamp_rects")]
        [XmlArrayItem("time_stamp_rect_open_v_o")]
        public List<TimeStampRectOpenVO> TimeStampRects { get; set; }
    }
}
