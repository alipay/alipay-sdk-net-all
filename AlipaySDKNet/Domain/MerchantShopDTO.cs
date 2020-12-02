using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantShopDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantShopDTO : AopObject
    {
        /// <summary>
        /// 门店名称，最长不超过256个字符。
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店编号。
        /// </summary>
        [XmlElement("shop_no")]
        public string ShopNo { get; set; }
    }
}
