using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TestHq Data Structure.
    /// </summary>
    [Serializable]
    public class TestHq : AopObject
    {
        /// <summary>
        /// 测试同步
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
