using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuStockInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SkuStockInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shift_stock_list")]
        [XmlArrayItem("shift_stock_v_o")]
        public List<ShiftStockVO> ShiftStockList { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
