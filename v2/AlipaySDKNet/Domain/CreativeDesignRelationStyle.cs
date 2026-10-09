using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeDesignRelationStyle Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeDesignRelationStyle : AopObject
    {
        /// <summary>
        /// 合成图片所需要的模版id
        /// </summary>
        [XmlElement("pic_template_id")]
        public string PicTemplateId { get; set; }

        /// <summary>
        /// style_design_content_url风格和布局唯一确定的背景图，返回的两者结合的图片地址。
        /// </summary>
        [XmlElement("style_design_relation_mock_img")]
        public string StyleDesignRelationMockImg { get; set; }

        /// <summary>
        /// style_id风格id，唯一
        /// </summary>
        [XmlElement("style_id")]
        public string StyleId { get; set; }

        /// <summary>
        /// style_content_url风格的背景图，唯一，返回的风格地址
        /// </summary>
        [XmlElement("style_mock_img")]
        public string StyleMockImg { get; set; }
    }
}
