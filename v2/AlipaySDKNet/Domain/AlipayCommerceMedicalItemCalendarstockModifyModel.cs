using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemCalendarstockModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemCalendarstockModifyModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sku_stock_list")]
        [XmlArrayItem("sku_stock_info")]
        public List<SkuStockInfo> SkuStockList { get; set; }

        /// <summary>
        /// OMS厂商门店编码, 录入门店时填写的值, 厂商自行维护
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
