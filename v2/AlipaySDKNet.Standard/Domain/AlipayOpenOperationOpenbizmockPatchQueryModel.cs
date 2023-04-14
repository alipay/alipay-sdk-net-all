using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockPatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockPatchQueryModel : AopObject
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
