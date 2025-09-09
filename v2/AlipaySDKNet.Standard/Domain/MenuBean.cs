using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MenuBean Data Structure.
    /// </summary>
    [Serializable]
    public class MenuBean : AopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("menu_id")]
        public string MenuId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// true/false -- 当且仅当 true 时才是必选，false 或者字段不存在，都表示非必选商品
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 排序标识
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }
    }
}
