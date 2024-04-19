using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityAzeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityAzeQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("in_a")]
        public string InA { get; set; }
    }
}
