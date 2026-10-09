using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceModelContext Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceModelContext : AopObject
    {
        /// <summary>
        /// xpId，服务调用唯一的设备标识
        /// </summary>
        [XmlElement("xp_id")]
        public string XpId { get; set; }
    }
}
