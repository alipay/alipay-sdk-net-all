using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdSssQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdSssQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("aaa")]
        public string Aaa { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("aaa_open_id")]
        public string AaaOpenId { get; set; }

        /// <summary>
        /// activity_id 词条描述
        /// </summary>
        [XmlElement("bbb")]
        public string Bbb { get; set; }

        /// <summary>
        /// stst
        /// </summary>
        [XmlArray("tesst")]
        [XmlArrayItem("promise_detail")]
        public List<PromiseDetail> Tesst { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("xxx")]
        public JinyouTestFive Xxx { get; set; }
    }
}
