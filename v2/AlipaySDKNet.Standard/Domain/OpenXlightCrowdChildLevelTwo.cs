using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenXlightCrowdChildLevelTwo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenXlightCrowdChildLevelTwo : AopObject
    {
        /// <summary>
        /// 人群类目第三层级子类目
        /// </summary>
        [XmlArray("children")]
        [XmlArrayItem("open_xlight_crowd_child_level_three")]
        public List<OpenXlightCrowdChildLevelThree> Children { get; set; }

        /// <summary>
        /// 该字段表明人群的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 该字段表明人群包的tagId，用户在创建和修改单元时可使用该值选中人群包
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 该参数表明人群覆盖量级
        /// </summary>
        [XmlElement("user_num")]
        public string UserNum { get; set; }
    }
}
