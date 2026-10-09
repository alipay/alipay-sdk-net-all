using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTerminalEdgecloudWorkorderChangemachineQueryResponse.
    /// </summary>
    public class AlipayTerminalEdgecloudWorkorderChangemachineQueryResponse : AopResponse
    {
        /// <summary>
        /// 维保换机工单列表，包含维保换机工单信息
        /// </summary>
        [XmlArray("work_order_list")]
        [XmlArrayItem("iot_care_work_order")]
        public List<IotCareWorkOrder> WorkOrderList { get; set; }
    }
}
