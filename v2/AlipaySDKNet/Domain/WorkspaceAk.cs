using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkspaceAk Data Structure.
    /// </summary>
    [Serializable]
    public class WorkspaceAk : AopObject
    {
        /// <summary>
        /// ak
        /// </summary>
        [XmlElement("access_key_id")]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// sk
        /// </summary>
        [XmlElement("access_key_secret")]
        public string AccessKeySecret { get; set; }
    }
}
