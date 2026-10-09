using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalSkuBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalSkuBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 门店商品sku信息列表，包含skuId,skuCode,spec,upc,price,stock等信息
        /// </summary>
        [XmlArray("sku_info_list")]
        [XmlArrayItem("item_sku_info_d_t_o")]
        public List<ItemSkuInfoDTO> SkuInfoList { get; set; }
    }
}
