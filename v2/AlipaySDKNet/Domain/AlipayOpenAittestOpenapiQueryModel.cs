using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAittestOpenapiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAittestOpenapiQueryModel : AopObject
    {
        /// <summary>
        /// AIT测试demo
        /// </summary>
        [XmlElement("ait_test_demo")]
        public string AitTestDemo { get; set; }

        /// <summary>
        /// AIT测试demo
        /// </summary>
        [XmlElement("ait_test_field")]
        public string AitTestField { get; set; }

        /// <summary>
        /// AIT测试demo
        /// </summary>
        [XmlElement("ait_test_value")]
        public string AitTestValue { get; set; }
    }
}
