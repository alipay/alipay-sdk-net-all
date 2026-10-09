using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockPutQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockPutQueryModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("b_query")]
        public string BQuery { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("c_body")]
        public string CBody { get; set; }
    }
}
