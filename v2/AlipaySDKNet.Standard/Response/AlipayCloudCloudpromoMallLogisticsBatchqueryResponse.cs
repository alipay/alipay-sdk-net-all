using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallLogisticsBatchqueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallLogisticsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 物流信息列表
        /// </summary>
        [XmlArray("mpc_logistics")]
        [XmlArrayItem("mpc_logistics_order_result")]
        public List<MpcLogisticsOrderResult> MpcLogistics { get; set; }
    }
}
