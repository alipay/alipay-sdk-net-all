using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EstablishResponseHeader Data Structure.
    /// </summary>
    [Serializable]
    public class EstablishResponseHeader : AopObject
    {
        /// <summary>
        /// 200=成功，400=请求错误，403=bundle查询不到。 Status code used to indicate an error, or "200" for success.
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// Not parsed programmatically. Example "Downstream system offline"
        /// </summary>
        [XmlElement("status_message")]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Conveys failure codes from downstream entities or for more granular conveyance of specific error conditions.
        /// </summary>
        [XmlElement("sub_status_code")]
        public string SubStatusCode { get; set; }
    }
}
