using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityLifeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityLifeQueryModel : AopObject
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
        [XmlElement("hh")]
        public bool Hh { get; set; }

        /// <summary>
        /// dfgdfgdf
        /// </summary>
        [XmlArray("sdgd")]
        [XmlArrayItem("date")]
        public List<string> Sdgd { get; set; }

        /// <summary>
        /// 手动的
        /// </summary>
        [XmlElement("xcvb")]
        public string Xcvb { get; set; }
    }
}
