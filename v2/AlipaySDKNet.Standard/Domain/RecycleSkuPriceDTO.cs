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
        /// 商户同步商品价格的扩展 当前字段已废弃(需要升级同步商品价格的扩展)
        /// </summary>
        [XmlArray("price_ext")]
        [XmlArrayItem("recycle_price_ext_d_t_o")]
        public List<RecyclePriceExtDTO> PriceExt { get; set; }

        /// <summary>
        /// 价格的扩展对象
        /// </summary>
        [XmlElement("price_extend")]
        public RecycleSkuPriceExtDTO PriceExtend { get; set; }

        /// <summary>
        /// 销售价（单位为元，金额超过1000就不允许小数点）
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 区间价时，回收商品会透出一个范围价格，包含最小值与最大值； 一口价时，回收商品只会透出一个准确的价格； 四品相价时，回收商品会针对4个品相透出4个区间价
        /// </summary>
        [XmlElement("sku_price_type")]
        public string SkuPriceType { get; set; }
    }
}
