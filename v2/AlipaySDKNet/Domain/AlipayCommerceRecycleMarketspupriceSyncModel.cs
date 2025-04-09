using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleMarketspupriceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleMarketspupriceSyncModel : AopObject
    {
        /// <summary>
        /// C2B:回收价：用户将旧机给回收商，回收商提供给C的回收价。 
        /// </summary>
        [XmlElement("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// product_code
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("recycle_sku_d_t_o")]
        public List<RecycleSkuDTO> Skus { get; set; }
    }
}
