using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantForm Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantForm : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 参与者账号
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 参与者账号类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 参与者账号
        /// </summary>
        [XmlElement("principal_open_id")]
        public string PrincipalOpenId { get; set; }
    }
}
