using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTestQinyuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestQinyuQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("oid")]
        public string Oid { get; set; }
    }
}
