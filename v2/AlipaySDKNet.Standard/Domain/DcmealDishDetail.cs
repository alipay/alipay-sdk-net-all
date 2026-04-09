using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DcmealDishDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DcmealDishDetail : AopObject
    {
        /// <summary>
        /// 菜品描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 智盘平台菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 智盘平台菜品名称
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品单价，单位元，保留两位小数
        /// </summary>
        [XmlElement("dish_price")]
        public string DishPrice { get; set; }

        /// <summary>
        /// 菜品售价，单位元，保留两位小数
        /// </summary>
        [XmlElement("dish_sale_amount")]
        public string DishSaleAmount { get; set; }

        /// <summary>
        /// "nutrition"
        /// </summary>
        [XmlElement("nutrition")]
        public string Nutrition { get; set; }

        /// <summary>
        /// unit
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 商品重量，单位为g
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// 菜品类型
        /// </summary>
        [XmlElement("weight_type")]
        public string WeightType { get; set; }
    }
}
