using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsOutboundorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 出库通知单明细列表
        /// </summary>
        [XmlArray("outbound_order_line_list")]
        [XmlArrayItem("outbound_order_line")]
        public List<OutboundOrderLine> OutboundOrderLineList { get; set; }

        /// <summary>
        /// 出库通知单
        /// </summary>
        [XmlElement("outbound_order_vo")]
        public OutboundOrderVO OutboundOrderVo { get; set; }
    }
}
