using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityAppinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityAppinfoQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("aaa")]
        public string Aaa { get; set; }
    }
}
