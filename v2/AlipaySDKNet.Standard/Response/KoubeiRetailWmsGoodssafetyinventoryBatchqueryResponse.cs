using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsGoodssafetyinventoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 货品安全库存列表
        /// </summary>
        [XmlArray("goods_safety_inventory_vo_list")]
        [XmlArrayItem("goods_safety_inventory_v_o")]
        public List<GoodsSafetyInventoryVO> GoodsSafetyInventoryVoList { get; set; }
    }
}
