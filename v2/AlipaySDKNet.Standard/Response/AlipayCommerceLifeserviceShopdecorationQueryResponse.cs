using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopdecorationQueryResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceShopdecorationQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_business_time")]
        [XmlArrayItem("life_service_shop_business_time")]
        public List<LifeServiceShopBusinessTime> ShopBusinessTime { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_commercial_tags")]
        [XmlArrayItem("string")]
        public List<string> ShopCommercialTags { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_decoration_attrs")]
        [XmlArrayItem("life_service_attr")]
        public List<LifeServiceAttr> ShopDecorationAttrs { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店logo头像url
        /// </summary>
        [XmlElement("shop_logo")]
        public string ShopLogo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_vibes_images")]
        [XmlArrayItem("string")]
        public List<string> ShopVibesImages { get; set; }
    }
}
