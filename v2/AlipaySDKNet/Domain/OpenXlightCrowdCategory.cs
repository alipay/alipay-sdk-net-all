using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenXlightCrowdCategory Data Structure.
    /// </summary>
    [Serializable]
    public class OpenXlightCrowdCategory : AopObject
    {
        /// <summary>
        /// 该参数表明行为兴趣人群类目层级一子类目
        /// </summary>
        [XmlArray("children")]
        [XmlArrayItem("open_xlight_crowd_child_level_one")]
        public List<OpenXlightCrowdChildLevelOne> Children { get; set; }

        /// <summary>
        /// 该参数表明人群包名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 该参数表示行为人群id，可在后续单元的创编上作为行为人群参数传回。
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 该参数表明当前人群包覆盖量级
        /// </summary>
        [XmlElement("user_num")]
        public string UserNum { get; set; }
    }
}
