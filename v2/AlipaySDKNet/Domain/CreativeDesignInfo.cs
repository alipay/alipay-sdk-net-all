using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeDesignInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeDesignInfo : AopObject
    {
        /// <summary>
        /// 布局对应的风格信息
        /// </summary>
        [XmlArray("creative_design_relation_style_list")]
        [XmlArrayItem("creative_design_relation_style")]
        public List<CreativeDesignRelationStyle> CreativeDesignRelationStyleList { get; set; }

        /// <summary>
        /// designId，返回的布局id
        /// </summary>
        [XmlElement("design_id")]
        public string DesignId { get; set; }

        /// <summary>
        /// 布局的背景图，唯一，返回图片的地址。
        /// </summary>
        [XmlElement("mock_img")]
        public string MockImg { get; set; }
    }
}
