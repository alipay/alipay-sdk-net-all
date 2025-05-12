using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ManjiantTest Data Structure.
    /// </summary>
    [Serializable]
    public class ManjiantTest : AopObject
    {
        /// <summary>
        /// defe
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// dddd
        /// </summary>
        [XmlElement("open_id_json")]
        public string OpenIdJson { get; set; }

        /// <summary>
        /// 22222222
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
