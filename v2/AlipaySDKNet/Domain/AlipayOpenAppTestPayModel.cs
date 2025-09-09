using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTestPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestPayModel : AopObject
    {
        /// <summary>
        /// desc
        /// </summary>
        [XmlElement("body_date")]
        public string BodyDate { get; set; }
    }
}
