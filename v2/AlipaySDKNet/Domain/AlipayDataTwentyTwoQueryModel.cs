using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataTwentyTwoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataTwentyTwoQueryModel : AopObject
    {
        /// <summary>
        /// body基础描述
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// id基础描述
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// id_open_id基础描述
        /// </summary>
        [XmlElement("id_open_id")]
        public string IdOpenId { get; set; }

        /// <summary>
        /// path基础描述
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// query基础描述
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
