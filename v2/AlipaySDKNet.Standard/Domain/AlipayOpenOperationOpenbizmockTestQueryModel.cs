using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestQueryModel : AopObject
    {
        /// <summary>
        /// 哈哈
        /// </summary>
        [XmlElement("fuza")]
        public TestDemoWzw Fuza { get; set; }

        /// <summary>
        /// 哈哈
        /// </summary>
        [XmlElement("out_open_id")]
        public string OutOpenId { get; set; }

        /// <summary>
        /// 哈哈
        /// </summary>
        [XmlElement("u_test")]
        public string UTest { get; set; }
    }
}
