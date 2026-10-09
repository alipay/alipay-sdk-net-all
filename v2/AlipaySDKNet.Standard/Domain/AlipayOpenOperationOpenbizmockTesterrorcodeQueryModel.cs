using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTesterrorcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTesterrorcodeQueryModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("keykey")]
        public string Keykey { get; set; }
    }
}
