using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcPayRestriction Data Structure.
    /// </summary>
    [Serializable]
    public class EcPayRestriction : AopObject
    {
        /// <summary>
        /// 账户使用条件类型
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 账户使用范围限定
        /// </summary>
        [XmlArray("ranges")]
        [XmlArrayItem("string")]
        public List<string> Ranges { get; set; }
    }
}
