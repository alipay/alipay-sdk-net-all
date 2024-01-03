using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ShopInfoDTO : AopObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 蚂蚁侧门店id
        /// </summary>
        [XmlElement("alipay_shop_id")]
        public string AlipayShopId { get; set; }

        /// <summary>
        /// 商家侧门店id
        /// </summary>
        [XmlElement("merchant_shop_id")]
        public string MerchantShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
