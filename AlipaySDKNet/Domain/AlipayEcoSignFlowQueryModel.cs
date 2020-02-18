using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoSignFlowQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoSignFlowQueryModel : AopObject
    {
        /// <summary>
        /// 流程id
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }
    }
}
