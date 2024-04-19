using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishVirtualDishSimplifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishVirtualDishSimplifyInfo : AopObject
    {
        /// <summary>
        /// 外部菜品id
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 菜品在虚拟类目中的排序值，只支持数字类型，如果不填默认1
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }
    }
}
