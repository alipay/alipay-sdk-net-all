using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAfxMuseUserBindResponse.
    /// </summary>
    public class AlipayAfxMuseUserBindResponse : AopResponse
    {
        /// <summary>
        /// muse 会话id
        /// </summary>
        [XmlElement("muse_session_id")]
        public string MuseSessionId { get; set; }
    }
}
