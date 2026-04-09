using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtDcmealMightydishdataInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtDcmealMightydishdataInfoSyncModel : AopObject
    {
        /// <summary>
        /// allergy_risk
        /// </summary>
        [XmlElement("allergy_risk")]
        public string AllergyRisk { get; set; }

        /// <summary>
        /// 园区ID
        /// </summary>
        [XmlElement("campus_id")]
        public string CampusId { get; set; }

        /// <summary>
        /// campus_name
        /// </summary>
        [XmlElement("campus_name")]
        public string CampusName { get; set; }

        /// <summary>
        /// category_id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// create_date
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// dietary
        /// </summary>
        [XmlElement("dietary")]
        public string Dietary { get; set; }

        /// <summary>
        /// 菜品信息
        /// </summary>
        [XmlElement("dish_img")]
        public string DishImg { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("food_id")]
        public string FoodId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [XmlElement("food_name")]
        public string FoodName { get; set; }

        /// <summary>
        /// food_no
        /// </summary>
        [XmlElement("food_no")]
        public string FoodNo { get; set; }

        /// <summary>
        /// labs_healthcard
        /// </summary>
        [XmlElement("labs_healthcard")]
        public string LabsHealthcard { get; set; }

        /// <summary>
        /// nutrition
        /// </summary>
        [XmlElement("nutrition")]
        public string Nutrition { get; set; }

        /// <summary>
        /// 已元为单位
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// restaurant_id
        /// </summary>
        [XmlElement("restaurant_id")]
        public string RestaurantId { get; set; }

        /// <summary>
        /// restaurant_name
        /// </summary>
        [XmlElement("restaurant_name")]
        public string RestaurantName { get; set; }

        /// <summary>
        /// special_population
        /// </summary>
        [XmlElement("special_population")]
        public string SpecialPopulation { get; set; }

        /// <summary>
        /// state
        /// </summary>
        [XmlElement("state")]
        public long State { get; set; }

        /// <summary>
        /// unit
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// update_date
        /// </summary>
        [XmlElement("update_date")]
        public string UpdateDate { get; set; }

        /// <summary>
        /// 已g为单位
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// weight_type
        /// </summary>
        [XmlElement("weight_type")]
        public string WeightType { get; set; }
    }
}
