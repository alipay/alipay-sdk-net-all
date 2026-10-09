using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 门店商品详情信息列表，包含单规格/多规格售卖信息
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_detail_info_d_t_o")]
        public List<ItemDetailInfoDTO> ItemList { get; set; }
    }
}
