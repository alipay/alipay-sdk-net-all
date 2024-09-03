using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemPriceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemPriceModifyModel : AopObject
    {
        /// <summary>
        /// 商品sku价格的json数据
        /// </summary>
        [XmlArray("skus_data")]
        [XmlArrayItem("sku_price_deatail")]
        public List<SkuPriceDeatail> SkusData { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
