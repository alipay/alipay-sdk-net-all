using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctoravatarinfoCopyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctoravatarinfoCopyModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("avatar_id")]
        public string AvatarId { get; set; }

        /// <summary>
        /// 文件地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
