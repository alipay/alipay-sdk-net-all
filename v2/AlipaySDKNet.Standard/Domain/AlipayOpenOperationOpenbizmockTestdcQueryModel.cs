using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestdcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestdcQueryModel : AopObject
    {
        /// <summary>
        /// 详细地址
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

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("d")]
        public string D { get; set; }
    }
}
