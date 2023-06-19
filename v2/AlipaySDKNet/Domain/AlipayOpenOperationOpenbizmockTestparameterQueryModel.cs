using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestparameterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestparameterQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }
    }
}
