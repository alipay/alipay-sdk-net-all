using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityTestmysqltoobQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityTestmysqltoobQueryModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
