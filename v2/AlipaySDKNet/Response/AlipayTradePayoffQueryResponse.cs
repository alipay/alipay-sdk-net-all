using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePayoffQueryResponse.
    /// </summary>
    public class AlipayTradePayoffQueryResponse : AopResponse
    {
        /// <summary>
        /// 1111
        /// </summary>
        [XmlElement("man_dddd_asaa")]
        public ManjiangTestComplexOneData ManDdddAsaa { get; set; }

        /// <summary>
        /// asdf
        /// </summary>
        [XmlElement("sadf")]
        public ResourcePackage Sadf { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sd")]
        public string Sd { get; set; }
    }
}
