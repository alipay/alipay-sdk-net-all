using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualdishQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishVirtualdishQueryModel : AopObject
    {
        /// <summary>
        /// 虚拟类目id，如果传入，也会做为查询条件
        /// </summary>
        [XmlElement("catetory_id")]
        public string CatetoryId { get; set; }

        /// <summary>
        /// 口碑侧门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
