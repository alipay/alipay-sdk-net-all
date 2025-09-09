using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceOnlinetestRainyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceOnlinetestRainyQueryModel : AopObject
    {
        /// <summary>
        /// a下普通字段a
        /// </summary>
        [XmlElement("a_test_a")]
        public string ATestA { get; set; }

        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }
    }
}
