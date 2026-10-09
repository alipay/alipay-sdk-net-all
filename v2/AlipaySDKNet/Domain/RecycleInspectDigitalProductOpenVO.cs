using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleInspectDigitalProductOpenVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleInspectDigitalProductOpenVO : AopObject
    {
        /// <summary>
        /// imei号
        /// </summary>
        [XmlElement("imei")]
        public string Imei { get; set; }
    }
}
