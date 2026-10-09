using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityQqqQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityQqqQueryModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
