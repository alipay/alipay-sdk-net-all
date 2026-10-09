using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdHaiguanNoauthCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdHaiguanNoauthCreateModel : AopObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("haha")]
        public string Haha { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlArray("test")]
        [XmlArrayItem("string")]
        public List<string> Test { get; set; }
    }
}
