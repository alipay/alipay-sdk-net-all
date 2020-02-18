using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsInboundorderBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 入库通知单列表
        /// </summary>
        [XmlArray("inbound_order_vo_list")]
        [XmlArrayItem("inbound_order_v_o")]
        public List<InboundOrderVO> InboundOrderVoList { get; set; }
    }
}
