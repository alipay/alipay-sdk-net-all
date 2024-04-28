using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchSessionDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchSessionDetailQueryModel : AopObject
    {
        /// <summary>
        /// 本次会话的主体ID
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
