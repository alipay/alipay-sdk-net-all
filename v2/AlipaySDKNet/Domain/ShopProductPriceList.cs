using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopProductPriceList Data Structure.
    /// </summary>
    [Serializable]
    public class ShopProductPriceList : AopObject
    {
        /// <summary>
        /// 服务商侧维护的外部门店 ID。
        /// </summary>
        [XmlElement("external_shop_id")]
        public string ExternalShopId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("product_list")]
        [XmlArrayItem("product_list")]
        public List<ProductList> ProductList { get; set; }

        /// <summary>
        /// 企业码内部门店 ID。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
