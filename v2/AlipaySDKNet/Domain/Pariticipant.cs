using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Pariticipant Data Structure.
    /// </summary>
    [Serializable]
    public class Pariticipant : AopObject
    {
        /// <summary>
        /// 风控主体标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 风控主体标识类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 风控主体名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
