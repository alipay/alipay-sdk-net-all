using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceShopInfo : AopObject
    {
        /// <summary>
        /// 商家门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商家门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
