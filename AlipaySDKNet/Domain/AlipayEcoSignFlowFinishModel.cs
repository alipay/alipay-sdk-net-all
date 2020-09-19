using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoSignFlowFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoSignFlowFinishModel : AopObject
    {
        /// <summary>
        /// 流程id
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }
    }
}
