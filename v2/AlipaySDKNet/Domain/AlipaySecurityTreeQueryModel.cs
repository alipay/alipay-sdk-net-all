using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityTreeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityTreeQueryModel : AopObject
    {
        /// <summary>
        /// 测试3
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
