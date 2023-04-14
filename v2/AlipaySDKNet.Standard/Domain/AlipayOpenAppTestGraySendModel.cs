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
    }
}
