using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionFlowprotocolQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionFlowprotocolQueryResponse : AopResponse
    {
        /// <summary>
        /// 协议列表
        /// </summary>
        [XmlArray("protocol_list")]
        [XmlArrayItem("flow_protocol")]
        public List<FlowProtocol> ProtocolList { get; set; }

        /// <summary>
        /// 协议流水号
        /// </summary>
        [XmlElement("protocol_sequence_id")]
        public string ProtocolSequenceId { get; set; }
    }
}
