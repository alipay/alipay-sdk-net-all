using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSkuPriceExtDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSkuPriceExtDTO : AopObject
    {
        /// <summary>
        /// 价格的个性化扩展列表
        /// </summary>
        [XmlArray("custom_prices")]
        [XmlArrayItem("recycle_sku_custom_price_d_t_o")]
        public List<RecycleSkuCustomPriceDTO> CustomPrices { get; set; }
    }
}
