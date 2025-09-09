using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenbizmocktoolsDanielQueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenbizmocktoolsDanielQueryResponse : AopResponse
    {
        /// <summary>
        /// faf
        /// </summary>
        [XmlElement("hello")]
        public string Hello { get; set; }
    }
}
