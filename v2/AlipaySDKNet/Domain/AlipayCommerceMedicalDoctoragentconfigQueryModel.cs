using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctoragentconfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctoragentconfigQueryModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("avatar_id")]
        public string AvatarId { get; set; }
    }
}
