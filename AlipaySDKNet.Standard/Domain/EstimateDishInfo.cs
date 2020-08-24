using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EstimateDishInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EstimateDishInfo : AopObject
    {
        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [XmlElement("inventory")]
        public string Inventory { get; set; }

        /// <summary>
        /// 外部菜品id
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }
    }
}
