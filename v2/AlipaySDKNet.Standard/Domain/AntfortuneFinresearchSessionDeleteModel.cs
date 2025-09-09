using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchSessionDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchSessionDeleteModel : AopObject
    {
        /// <summary>
        /// 合作方用户标识
        /// </summary>
        [XmlElement("bu_unique_id")]
        public string BuUniqueId { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
