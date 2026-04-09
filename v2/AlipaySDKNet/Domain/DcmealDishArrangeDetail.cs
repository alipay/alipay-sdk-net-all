using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DcmealDishArrangeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DcmealDishArrangeDetail : AopObject
    {
        /// <summary>
        /// 排菜ID
        /// </summary>
        [XmlElement("arrange_id")]
        public string ArrangeId { get; set; }

        /// <summary>
        /// 园区ID
        /// </summary>
        [XmlElement("campus_id")]
        public string CampusId { get; set; }

        /// <summary>
        /// 园区名称
        /// </summary>
        [XmlElement("campus_name")]
        public string CampusName { get; set; }

        /// <summary>
        /// 菜品ID
        /// </summary>
        [XmlElement("food_id")]
        public string FoodId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [XmlElement("food_name")]
        public string FoodName { get; set; }

        /// <summary>
        /// 餐别名称
        /// </summary>
        [XmlElement("meal_type")]
        public string MealType { get; set; }

        /// <summary>
        /// 价格，单位为“元”
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 餐厅ID
        /// </summary>
        [XmlElement("restaurant_id")]
        public string RestaurantId { get; set; }

        /// <summary>
        /// 餐厅名称
        /// </summary>
        [XmlElement("restaurant_name")]
        public string RestaurantName { get; set; }

        /// <summary>
        /// 极具ID
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 机具名称
        /// </summary>
        [XmlElement("terminal_name")]
        public string TerminalName { get; set; }
    }
}
