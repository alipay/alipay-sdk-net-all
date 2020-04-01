using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderShopInfo : AopObject
    {
        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 商户门店id 支持英文、数字的组合
        /// </summary>
        [XmlElement("merchant_shop_id")]
        public string MerchantShopId { get; set; }

        /// <summary>
        /// 店铺详情链接地址
        /// </summary>
        [XmlElement("merchant_shop_link_page")]
        public string MerchantShopLinkPage { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系电话-支持固话或手机号 仅支持数字、+、-
        /// </summary>
        [XmlElement("phone_num")]
        public string PhoneNum { get; set; }
    }
}
