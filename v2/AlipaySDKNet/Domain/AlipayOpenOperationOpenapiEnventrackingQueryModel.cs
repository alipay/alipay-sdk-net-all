using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenapiEnventrackingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenapiEnventrackingQueryModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("u_tset")]
        public string UTset { get; set; }
    }
}
