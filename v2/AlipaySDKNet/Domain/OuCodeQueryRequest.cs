using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OuCodeQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class OuCodeQueryRequest : AopObject
    {
        /// <summary>
        /// ou编码
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }
    }
}
