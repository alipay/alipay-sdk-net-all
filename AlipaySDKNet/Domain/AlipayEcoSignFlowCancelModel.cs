using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoSignFlowCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoSignFlowCancelModel : AopObject
    {
        /// <summary>
        /// 流程id
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 撤销原因,默认"撤销"
        /// </summary>
        [XmlElement("revoke_reason")]
        public string RevokeReason { get; set; }
    }
}
