using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbVirtualShopCategoryDishInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbVirtualShopCategoryDishInfo : AopObject
    {
        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 菜品在虚拟类目中的排序值
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }
    }
}
