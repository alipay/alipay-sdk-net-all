using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSkuPriceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSkuPriceDTO : AopObject
    {
        /// <summary>
        /// 最高价（单位为元，金额超过1000就不允许小数点）
        /// </summary>
        [XmlElement("max_price")]
        public string MaxPrice { get; set; }

        /// <summary>
        /// 最低价（单位为元，金额超过1000就不允许小数点）
        /// </summary>
        [XmlElement("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("price_ext")]
        [XmlArrayItem("recycle_price_ext_d_t_o")]
        public List<RecyclePriceExtDTO> PriceExt { get; set; }

        /// <summary>
        /// 价格的扩展对象
        /// </summary>
        [XmlElement("price_extend")]
        public RecycleSkuPriceExtDTO PriceExtend { get; set; }
    }
}
