using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcActivityOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcActivityOfflineModel : AopObject
    {
        /// <summary>
        /// 员工价活动id，用于指定需要下线的活动；通过 alipay.commerce.ec.activity.discount.create 创建活动
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 蚂蚁门店id，用于水平权限鉴权。可通过ant.merchant.expand.shop.create创建蚂蚁门店获取
        /// </summary>
        [XmlElement("ant_shop_id")]
        public string AntShopId { get; set; }
    }
}
