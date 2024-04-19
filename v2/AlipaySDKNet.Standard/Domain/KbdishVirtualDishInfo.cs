using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishVirtualDishInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishVirtualDishInfo : AopObject
    {
        /// <summary>
        /// 虚拟分类id
        /// </summary>
        [XmlElement("catetory_id")]
        public string CatetoryId { get; set; }

        /// <summary>
        /// 创建
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 扩展定制
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 菜品在虚拟类目下的排序值
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
