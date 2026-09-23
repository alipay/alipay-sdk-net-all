using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentGovernanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentGovernanceQueryModel : AopObject
    {
        /// <summary>
        /// 如果传了target_id则只返回匹配的记录
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }
    }
}
