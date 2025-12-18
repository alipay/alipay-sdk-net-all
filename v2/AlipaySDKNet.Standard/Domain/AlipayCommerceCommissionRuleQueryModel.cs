using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommissionRuleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommissionRuleQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁门店id，用于水平权限鉴权。可通过ant.merchant.expand.shop.create创建蚂蚁门店获取
        /// </summary>
        [XmlElement("ant_shop_id")]
        public string AntShopId { get; set; }
    }
}
