using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpInteopOpauthCreateResponse.
    /// </summary>
    public class AlipayOpenSpInteopOpauthCreateResponse : AopResponse
    {
        /// <summary>
        /// 代运营授权信息，记录创建代运营授权子单以及对应的产品信息。
        /// </summary>
        [XmlArray("agent_operation_auth_details")]
        [XmlArrayItem("agent_operation_auth_detail")]
        public List<AgentOperationAuthDetail> AgentOperationAuthDetails { get; set; }
    }
}
