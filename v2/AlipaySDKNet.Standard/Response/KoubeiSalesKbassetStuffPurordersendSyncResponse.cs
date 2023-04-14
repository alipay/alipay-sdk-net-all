using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffPurordersendSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffPurordersendSyncResponse : AopResponse
    {
        /// <summary>
        /// 供应商同步发货信息及物流信息处理结果列表
        /// </summary>
        [XmlArray("purchase_order_send_results")]
        [XmlArrayItem("access_purchase_order_send_result")]
        public List<AccessPurchaseOrderSendResult> PurchaseOrderSendResults { get; set; }
    }
}
