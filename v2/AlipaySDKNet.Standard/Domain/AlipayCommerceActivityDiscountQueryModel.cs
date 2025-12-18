using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceActivityDiscountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceActivityDiscountQueryModel : AopObject
    {
        /// <summary>
        /// 活动ID，用于查询指定的活动。创建活动接口获取
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 蚂蚁门店ID，用于水平权限鉴权。蚂蚁门店id，用于水平权限鉴权。可通过ant.merchant.expand.shop.create创建蚂蚁门店获取
        /// </summary>
        [XmlElement("ant_shop_id")]
        public string AntShopId { get; set; }
    }
}
