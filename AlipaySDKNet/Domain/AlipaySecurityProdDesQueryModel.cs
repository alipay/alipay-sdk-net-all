using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdDesQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdDesQueryModel : AopObject
    {
        /// <summary>
        /// 121
        /// </summary>
        [XmlElement("com")]
        public GavinTestnew Com { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("test")]
        [XmlArrayItem("string")]
        public List<string> Test { get; set; }
    }
}
