using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DcmealDishCategoryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DcmealDishCategoryDetail : AopObject
    {
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
        /// 分类ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 分类编号
        /// </summary>
        [XmlElement("category_no")]
        public string CategoryNo { get; set; }

        /// <summary>
        /// 父类ID
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

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
    }
}
