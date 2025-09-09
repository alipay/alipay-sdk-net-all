using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchSessionHistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchSessionHistoryQueryModel : AopObject
    {
        /// <summary>
        /// 本次会话的主体ID
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }
    }
}
