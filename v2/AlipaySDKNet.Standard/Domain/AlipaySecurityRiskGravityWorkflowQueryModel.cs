using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskGravityWorkflowQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskGravityWorkflowQueryModel : AopObject
    {
        /// <summary>
        /// 合规流程的主键id
        /// </summary>
        [XmlElement("pu_id")]
        public string PuId { get; set; }
    }
}
