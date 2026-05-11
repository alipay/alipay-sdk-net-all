using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemCalendarstockModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemCalendarstockModifyResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("sku_stock_price_result_v_o")]
        public List<SkuStockPriceResultVO> FailList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("sku_stock_price_result_v_o")]
        public List<SkuStockPriceResultVO> SuccList { get; set; }
    }
}
