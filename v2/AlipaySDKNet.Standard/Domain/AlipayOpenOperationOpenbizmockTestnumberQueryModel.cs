using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestnumberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestnumberQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("keykey")]
        public string Keykey { get; set; }
    }
}
