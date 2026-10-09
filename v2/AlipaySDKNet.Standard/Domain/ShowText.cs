using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShowText Data Structure.
    /// </summary>
    [Serializable]
    public class ShowText : AopObject
    {
        /// <summary>
        /// 订单对应的菜品档口信息，用于小程序页面文案展示，如：早餐/午餐/晚餐/夜宵
        /// </summary>
        [XmlElement("meal_desc")]
        public string MealDesc { get; set; }
    }
}
