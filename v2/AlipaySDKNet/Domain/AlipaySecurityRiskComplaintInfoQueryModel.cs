using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskComplaintInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskComplaintInfoQueryModel : AopObject
    {
        /// <summary>
        /// 投诉主表主键id
        /// </summary>
        [XmlElement("complain_id")]
        public string ComplainId { get; set; }
    }
}
