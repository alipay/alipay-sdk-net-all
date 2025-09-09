using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPickupShopInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPickupShopInfoDTO : AopObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 蚂蚁侧门店ID
        /// </summary>
        [XmlElement("alipay_shop_id")]
        public string AlipayShopId { get; set; }

        /// <summary>
        /// 商家侧门店ID
        /// </summary>
        [XmlElement("merchant_shop_id")]
        public string MerchantShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 门店联系电话
        /// </summary>
        [XmlElement("tel_number")]
        public string TelNumber { get; set; }
    }
}
