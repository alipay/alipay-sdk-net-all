using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayUserInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayUserInfoDTO : AopObject
    {
        /// <summary>
        /// 主体类型
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 主体id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
