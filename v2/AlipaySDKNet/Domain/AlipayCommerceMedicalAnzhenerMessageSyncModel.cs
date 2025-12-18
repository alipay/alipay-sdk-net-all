using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAnzhenerMessageSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAnzhenerMessageSyncModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
