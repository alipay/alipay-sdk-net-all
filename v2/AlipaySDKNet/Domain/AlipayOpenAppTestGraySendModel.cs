using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTestGraySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestGraySendModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("oid")]
        public string Oid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("tid")]
        public string Tid { get; set; }
    }
}
