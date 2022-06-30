using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityLifeQueryResponse.
    /// </summary>
    public class AlipaySecurityLifeQueryResponse : AopResponse
    {
        /// <summary>
        /// asfsdf
        /// </summary>
        [XmlArray("dsfg")]
        [XmlArrayItem("ape_rec_context")]
        public List<ApeRecContext> Dsfg { get; set; }

        /// <summary>
        /// sdegdfg
        /// </summary>
        [XmlArray("grt")]
        [XmlArrayItem("string")]
        public List<string> Grt { get; set; }

        /// <summary>
        /// sfdsfdsfsdf
        /// </summary>
        [XmlArray("hh")]
        [XmlArrayItem("boolean")]
        public List<bool> Hh { get; set; }

        /// <summary>
        /// dvf
        /// </summary>
        [XmlElement("jsdfjsd")]
        public string Jsdfjsd { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// dfgdfgdf
        /// </summary>
        [XmlArray("sdgd")]
        [XmlArrayItem("date")]
        public List<string> Sdgd { get; set; }
    }
}
