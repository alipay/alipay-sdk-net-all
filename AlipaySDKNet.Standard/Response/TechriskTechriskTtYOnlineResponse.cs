using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskTechriskTtYOnlineResponse.
    /// </summary>
    public class TechriskTechriskTtYOnlineResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
