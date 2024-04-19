using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeResultpicCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApecreativeResultpicCreateModel : AopObject
    {
        /// <summary>
        /// 文本信息
        /// </summary>
        [XmlArray("creative_item_design_text_list")]
        [XmlArrayItem("item_design_text_info")]
        public List<ItemDesignTextInfo> CreativeItemDesignTextList { get; set; }

        /// <summary>
        /// 行业描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// ape创意组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 合成图片时所需的高
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 风格id list
        /// </summary>
        [XmlArray("style_id_list")]
        [XmlArrayItem("string")]
        public List<string> StyleIdList { get; set; }

        /// <summary>
        /// 合成图片时所需的宽
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
