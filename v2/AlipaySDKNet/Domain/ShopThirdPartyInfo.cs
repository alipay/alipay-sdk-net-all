using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopThirdPartyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopThirdPartyInfo : AopObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店logo链接
        /// </summary>
        [XmlElement("store_logo_url")]
        public string StoreLogoUrl { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }
    }
}
