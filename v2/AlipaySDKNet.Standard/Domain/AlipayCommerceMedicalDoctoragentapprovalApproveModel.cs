using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctoragentapprovalApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctoragentapprovalApproveModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("avatar_id")]
        public string AvatarId { get; set; }
    }
}
