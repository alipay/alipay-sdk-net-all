using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentSkuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentSkuInfo : AopObject
    {
        /// <summary>
        /// sku属性信息
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("rent_sku_attr_info")]
        public List<RentSkuAttrInfo> Attrs { get; set; }

        /// <summary>
        /// 商家侧SKUID
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 平台SPUID
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }
    }
}
