using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemStockModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemStockModifyModel : AopObject
    {
        /// <summary>
        /// 商品库存
        /// </summary>
        [XmlArray("skus_data")]
        [XmlArrayItem("sku_stock_detail")]
        public List<SkuStockDetail> SkusData { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
