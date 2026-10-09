using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityJhjtestaaTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityJhjtestaaTestQueryModel : AopObject
    {
        /// <summary>
        /// 撒旦撒旦
        /// </summary>
        [XmlElement("ap_id")]
        public string ApId { get; set; }

        /// <summary>
        /// 撒旦撒旦
        /// </summary>
        [XmlElement("ap_open_id")]
        public string ApOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("complex_pri")]
        public PriNestOther ComplexPri { get; set; }
    }
}
