using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSkuDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSkuDTO : AopObject
    {
        /// <summary>
        /// 当前sku的过期时间，如果为空时，不同的场景平台会有默认的过期时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 商品款式的描述，例如一款商品有3个属性进行选择，那么款式列表里需要包含3个属性的具体选项，与回收的问券和选项一致
        /// </summary>
        [XmlArray("sku_attrs")]
        [XmlArrayItem("recycle_sku_attr_d_t_o")]
        public List<RecycleSkuAttrDTO> SkuAttrs { get; set; }

        /// <summary>
        /// 具体款式商品的价格，包含最低价与最高价
        /// </summary>
        [XmlElement("sku_price")]
        public RecycleSkuPriceDTO SkuPrice { get; set; }

        /// <summary>
        /// 描述某款式商品的上下架状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
