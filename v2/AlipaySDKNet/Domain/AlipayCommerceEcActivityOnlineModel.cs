using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcActivityOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcActivityOnlineModel : AopObject
    {
        /// <summary>
        /// 员工价活动id，指定需要上线的活动；通过 alipay.commerce.ec.activity.discount.create 创建活动
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 蚂蚁门店id；通过 ant.merchant.expand.shop.create 创建蚂蚁门店
        /// </summary>
        [XmlElement("ant_shop_id")]
        public string AntShopId { get; set; }
    }
}
