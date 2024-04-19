using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategoryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishVirtualcategoryDeleteModel : AopObject
    {
        /// <summary>
        /// 如果需要删除某一个类目时传入
        /// </summary>
        [XmlElement("catetory_name")]
        public string CatetoryName { get; set; }

        /// <summary>
        /// 外部门店id，与口碑门店id二选一必填，如果都填，以口碑门店id为准
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
