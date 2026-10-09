using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataHqteessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataHqteessQueryModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public TestHq Test { get; set; }
    }
}
