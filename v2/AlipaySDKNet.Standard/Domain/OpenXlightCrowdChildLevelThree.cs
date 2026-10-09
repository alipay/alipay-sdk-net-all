using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenXlightCrowdChildLevelThree Data Structure.
    /// </summary>
    [Serializable]
    public class OpenXlightCrowdChildLevelThree : AopObject
    {
        /// <summary>
        /// 该参数表示人群类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 行为兴趣人群包类目id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 该参数表示人群类目覆盖人群
        /// </summary>
        [XmlElement("user_num")]
        public string UserNum { get; set; }
    }
}
