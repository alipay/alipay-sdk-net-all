using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishVirtualcategoryQueryModel : AopObject
    {
        /// <summary>
        /// 虚拟类目名称
        /// </summary>
        [XmlElement("catetory_name")]
        public string CatetoryName { get; set; }

        /// <summary>
        /// 外部门店id，和shop_id二选一必填，当都传时，以shop_id为准
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
