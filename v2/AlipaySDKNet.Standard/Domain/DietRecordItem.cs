using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DietRecordItem Data Structure.
    /// </summary>
    [Serializable]
    public class DietRecordItem : AopObject
    {
        /// <summary>
        /// AI 热量估算 kcal
        /// </summary>
        [XmlElement("ai_calorie")]
        public string AiCalorie { get; set; }

        /// <summary>
        /// 饮食评估整句摘要
        /// </summary>
        [XmlElement("ai_summary")]
        public string AiSummary { get; set; }

        /// <summary>
        /// 碳水 g
        /// </summary>
        [XmlElement("carbohydrate")]
        public string Carbohydrate { get; set; }

        /// <summary>
        /// 脂肪 g
        /// </summary>
        [XmlElement("fat")]
        public string Fat { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("food_image_urls")]
        [XmlArrayItem("string")]
        public List<string> FoodImageUrls { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("food_items")]
        [XmlArrayItem("food_item")]
        public List<FoodItem> FoodItems { get; set; }

        /// <summary>
        /// 餐次编码
        /// </summary>
        [XmlElement("meal_type")]
        public string MealType { get; set; }

        /// <summary>
        /// 餐次名称
        /// </summary>
        [XmlElement("meal_type_name")]
        public string MealTypeName { get; set; }

        /// <summary>
        /// 蛋白质g
        /// </summary>
        [XmlElement("protein")]
        public string Protein { get; set; }

        /// <summary>
        /// 记录日期 yyyy-MM-dd
        /// </summary>
        [XmlElement("record_date")]
        public string RecordDate { get; set; }

        /// <summary>
        /// 记录业务 ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 记录时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("record_time")]
        public string RecordTime { get; set; }

        /// <summary>
        /// 文字描述（input_mode=2 时有值）
        /// </summary>
        [XmlElement("text_desc")]
        public string TextDesc { get; set; }
    }
}
