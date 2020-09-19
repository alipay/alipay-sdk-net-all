using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishEstimateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishEstimateQueryModel : AopObject
    {
        /// <summary>
        /// 外部门店id，外部门店id和口碑门店id，必须二选一必填，当都传入时，以口碑门店id为准
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
