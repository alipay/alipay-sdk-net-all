using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemPriceModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemPriceModifyResponse : AopResponse
    {
        /// <summary>
        /// 该参数代表批量操作失败的列表，会具体返回失败的商品信息以及失败代码和失败原因。
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("sku_stock_price_result_v_o")]
        public List<SkuStockPriceResultVO> FailList { get; set; }

        /// <summary>
        /// 该参数代表商家批量操作成功的列表，返回成功的商品具体信息。
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("sku_stock_price_result_v_o")]
        public List<SkuStockPriceResultVO> SuccList { get; set; }
    }
}
